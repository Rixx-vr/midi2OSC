using System.Diagnostics;

namespace Midi2OSC
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Rixx-vr/midi2OSC",
                UseShellExecute = true
            });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
