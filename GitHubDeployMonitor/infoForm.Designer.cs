using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    partial class infoForm
    {
        private Label label;
        private Button btnGenerate;
        private Button btnOK;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoForm));
            label = new Label();
            btnGenerate = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(260, 118);
            label.TabIndex = 2;
            label.Text = resources.GetString("label.Text");
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 124);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Private API Key";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(197, 124);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // infoForm
            // 
            ClientSize = new Size(274, 154);
            Controls.Add(btnOK);
            Controls.Add(btnGenerate);
            Controls.Add(label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "infoForm";
            Text = "Info";
            ResumeLayout(false);
        }
    }
}
