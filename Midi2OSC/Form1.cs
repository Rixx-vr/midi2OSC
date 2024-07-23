using NAudio.Midi;
using SharpOSC;

namespace Midi2OSC
{
    public partial class Form1 : Form
    {
        private MidiIn midiIn;
        private UDPSender oscSender;

        private List<long> noteTimestamps = new List<long>();
        private DateTime lastTimestamp = DateTime.MinValue;

        public Form1()
        {
            InitializeComponent();
            LoadMidiDevices();
        }

        private void LoadMidiDevices()
        {
            for (int i = 0; i < MidiIn.NumberOfDevices; i++)
            {
                comboBoxMidiDevices.Items.Add(MidiIn.DeviceInfo(i).ProductName);
            }

            if (comboBoxMidiDevices.Items.Count > 0)
            {
                comboBoxMidiDevices.SelectedIndex = 0;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxMidiDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a MIDI device.");
                return;
            }

            if (!int.TryParse(textBoxPort.Text, out int port))
            {
                MessageBox.Show("Please enter a valid port number.");
                return;
            }

            string ip = textBoxIP.Text;

            try
            {
                midiIn = new MidiIn(comboBoxMidiDevices.SelectedIndex);
                midiIn.MessageReceived += MidiIn_MessageReceived;
                midiIn.ErrorReceived += MidiIn_ErrorReceived;
                midiIn.Start();

                oscSender = new UDPSender(ip, port);

                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;

                updateTimer.Start();

                MessageBox.Show("Connected successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                midiIn.Stop();
                midiIn.Dispose();
                oscSender.Close();

                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;

                updateTimer.Stop();

                MessageBox.Show("Disconnected successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void MidiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            var midiMessage = e.MidiEvent;
            string messageType = midiMessage.CommandCode.ToString();
            int channel = midiMessage.Channel;
            int data1 = midiMessage.GetAsShortMessage() & 0xFF;
            int data2 = (midiMessage.GetAsShortMessage() >> 8) & 0xFF;
            int data3 = (midiMessage.GetAsShortMessage() >> 16) & 0xFF;

            // Create midi OSC message
            var oscMessage = new OscMessage("/OSC/MIDI", messageType, channel, data1, data2, data3);
            oscSender.Send(oscMessage);

            // Track timestamp for metrics
            long currentTimestamp = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;
            noteTimestamps.Add(currentTimestamp);
        }

        private void MidiIn_ErrorReceived(object sender, MidiInMessageEventArgs e)
        {
            MessageBox.Show($"MIDI Error: {e.MidiEvent}");
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateMetrics();
        }

        private void UpdateMetrics()
        {
            // Clean up old timestamps
            long now = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;
            noteTimestamps = noteTimestamps.Where(ts => now - ts <= 1000).ToList();

            // Calculate notes per second
            double meanVariation = 0;
            double notesPerSecond = noteTimestamps.Count / 1.0;
            labelFrequency.Text = $"Notes/sec: {notesPerSecond:F2}";

            // Calculate mean variation between notes
            if (noteTimestamps.Count > 1)
            {
                var intervals = noteTimestamps.Zip(noteTimestamps.Skip(1), (a, b) => b - a).ToList();
                meanVariation = intervals.Average();
                labelMeanVariation.Text = $"Mean Variation (ms): {meanVariation:F2}";
            }
            else
            {
                labelMeanVariation.Text = "Mean Variation (ms): 0.00";
            }

            // Create stats OSC message
            var oscMessage = new OscMessage("/OSC/MIDI_stats", (float) notesPerSecond, (float) meanVariation);
            oscSender.Send(oscMessage);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
