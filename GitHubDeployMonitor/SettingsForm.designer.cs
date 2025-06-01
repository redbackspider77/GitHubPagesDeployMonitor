namespace GitHubDeployMonitor
{
    partial class SettingsForm
    {
        private Label label1;
        private Label label2;
        private TextBox repoTextBox;
        private RadioButton publicKeyRadio;
        private RadioButton privateKeyRadio;
        private TextBox apiKeyTextBox;
        private Button saveButton;
        private Button infoButton;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            label1 = new Label();
            label2 = new Label();
            repoTextBox = new TextBox();
            publicKeyRadio = new RadioButton();
            privateKeyRadio = new RadioButton();
            apiKeyTextBox = new TextBox();
            saveButton = new Button();
            infoButton = new Button();
            numInterval = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 15);
            label1.TabIndex = 7;
            label1.Text = "GitHub Page To Monitor Directory (owner/repo):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 6;
            label2.Text = "Use private API key?";
            // 
            // repoTextBox
            // 
            repoTextBox.Location = new Point(12, 27);
            repoTextBox.Name = "repoTextBox";
            repoTextBox.Size = new Size(309, 23);
            repoTextBox.TabIndex = 5;
            repoTextBox.Text = Properties.Settings.Default.RepoDirectory;
            // 
            // publicKeyRadio
            // 
            publicKeyRadio.AutoSize = true;
            publicKeyRadio.Location = new Point(12, 78);
            publicKeyRadio.Name = "publicKeyRadio";
            publicKeyRadio.Size = new Size(41, 19);
            publicKeyRadio.TabIndex = 4;
            publicKeyRadio.Text = "No";
            // 
            // privateKeyRadio
            // 
            privateKeyRadio.AutoSize = true;
            privateKeyRadio.Location = new Point(12, 100);
            privateKeyRadio.Name = "privateKeyRadio";
            privateKeyRadio.Size = new Size(115, 19);
            privateKeyRadio.TabIndex = 3;
            privateKeyRadio.Text = "Yes (enter below)";
            // 
            // apiKeyTextBox
            // 
            apiKeyTextBox.Location = new Point(12, 125);
            apiKeyTextBox.Name = "apiKeyTextBox";
            apiKeyTextBox.Size = new Size(309, 23);
            apiKeyTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(201, 193);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save and Start";
            saveButton.Click += saveButton_Click;
            // 
            // infoButton
            // 
            infoButton.Location = new Point(130, 55);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(24, 24);
            infoButton.TabIndex = 0;
            infoButton.Text = "?";
            infoButton.Click += infoButton_Click;
            // 
            // numInterval
            // 
            numInterval.Location = new Point(13, 177);
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(120, 23);
            numInterval.TabIndex = 8;
            numInterval.Minimum = 100;
            numInterval.Maximum = 600000;
            numInterval.Increment = 1000;
            numInterval.Value = Properties.Settings.Default.CheckInterval;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(321, 15);
            label3.TabIndex = 9;
            label3.Text = "Check interval (how many milliseconds in between checks):";
            // 
            // SettingsForm
            // 
            ClientSize = new Size(337, 225);
            Controls.Add(label3);
            Controls.Add(numInterval);
            Controls.Add(infoButton);
            Controls.Add(saveButton);
            Controls.Add(apiKeyTextBox);
            Controls.Add(privateKeyRadio);
            Controls.Add(publicKeyRadio);
            Controls.Add(repoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private NumericUpDown numInterval;
        private Label label3;
    }
}