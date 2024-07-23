
namespace Midi2OSC
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxMidiDevices;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelMeanVariation;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxMidiDevices = new ComboBox();
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelFrequency = new Label();
            labelMeanVariation = new Label();
            updateTimer = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxMidiDevices
            // 
            comboBoxMidiDevices.FormattingEnabled = true;
            comboBoxMidiDevices.Location = new Point(12, 48);
            comboBoxMidiDevices.Name = "comboBoxMidiDevices";
            comboBoxMidiDevices.Size = new Size(260, 23);
            comboBoxMidiDevices.TabIndex = 0;
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(12, 95);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(260, 23);
            textBoxIP.TabIndex = 1;
            textBoxIP.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(12, 141);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(260, 23);
            textBoxPort.TabIndex = 2;
            textBoxPort.Text = "9999";
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 177);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(125, 25);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Enabled = false;
            buttonDisconnect.Location = new Point(147, 177);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(125, 25);
            buttonDisconnect.TabIndex = 4;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 5;
            label1.Text = "MIDI Devices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Server IP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Port:";
            // 
            // labelFrequency
            // 
            labelFrequency.AutoSize = true;
            labelFrequency.Location = new Point(12, 213);
            labelFrequency.Name = "labelFrequency";
            labelFrequency.Size = new Size(87, 15);
            labelFrequency.TabIndex = 8;
            labelFrequency.Text = "Notes/sec: 0.00";
            // 
            // labelMeanVariation
            // 
            labelMeanVariation.AutoSize = true;
            labelMeanVariation.Location = new Point(12, 236);
            labelMeanVariation.Name = "labelMeanVariation";
            labelMeanVariation.Size = new Size(140, 15);
            labelMeanVariation.TabIndex = 9;
            labelMeanVariation.Text = "Mean Variation (ms): 0.00";
            // 
            // updateTimer
            // 
            updateTimer.Interval = 1000;
            updateTimer.Tick += updateTimer_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(284, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 259);
            Controls.Add(labelMeanVariation);
            Controls.Add(labelFrequency);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIP);
            Controls.Add(comboBoxMidiDevices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MIDI to OSC";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
