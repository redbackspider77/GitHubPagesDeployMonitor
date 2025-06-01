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
            label = new Label();
            btnGenerate = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(260, 60);
            label.TabIndex = 2;
            label.Text = "Generate a personal access token with 'repo' and 'workflow' scopes and paste it in the API key box in settings for private repos.";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(3, 60);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(160, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Private API Key";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(197, 60);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // infoForm
            // 
            ClientSize = new Size(274, 92);
            Controls.Add(btnOK);
            Controls.Add(btnGenerate);
            Controls.Add(label);
            Name = "infoForm";
            Text = "Info";
            ResumeLayout(false);
        }
    }
}
