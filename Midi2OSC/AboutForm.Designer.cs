namespace Midi2OSC
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.LinkLabel linkLabel;

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
            labelInfo = new Label();
            linkLabel = new LinkLabel();
            closeButton = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(15, 15);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(234, 15);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "This is a MIDI to OSC converter.\n" +
                "released under MIT License by Rixx (Rixx-vr)";

            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new Point(15, 46);
            linkLabel.Margin = new Padding(4, 0, 4, 0);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(72, 15);
            linkLabel.TabIndex = 1;
            linkLabel.TabStop = true;
            linkLabel.Text = "Visit repo on github";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // button1
            // 
            closeButton.Location = new Point(115, 98);
            closeButton.Name = "close";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 133);
            Controls.Add(closeButton);
            Controls.Add(linkLabel);
            Controls.Add(labelInfo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AboutForm";
            Text = "About MIDI to OSC";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button closeButton;
    }
}