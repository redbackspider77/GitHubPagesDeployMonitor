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
            label3 = new Label();
            numInterval = new NumericUpDown();
            listBox = new ListBox();
            label4 = new Label();
            addString = new TextBox();
            addButton = new Button();
            removeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numInterval).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 15);
            label1.TabIndex = 7;
            label1.Text = "GitHub Page To Monitor Directory (owner/repo):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 60);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 6;
            label2.Text = "Use personal API key?";
            // 
            // repoTextBox
            // 
            repoTextBox.Location = new Point(12, 27);
            repoTextBox.Name = "repoTextBox";
            repoTextBox.Size = new Size(309, 23);
            repoTextBox.TabIndex = 5;
            repoTextBox.Text = "octocat/octocat.github.io";
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
            saveButton.Location = new Point(205, 303);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save and Start";
            saveButton.Click += saveButton_Click;
            // 
            // infoButton
            // 
            infoButton.Cursor = Cursors.Help;
            infoButton.Location = new Point(131, 56);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(24, 24);
            infoButton.TabIndex = 0;
            infoButton.Text = "?";
            infoButton.Click += infoButton_Click;
            // 
            // label3
            // 
            label3.Location = new Point(4, 271);
            label3.Name = "label3";
            label3.Size = new Size(321, 51);
            label3.TabIndex = 9;
            label3.Text = "Check for new commit and monitor checks every                                                  milliseconds.";
            // 
            // numInterval
            // 
            numInterval.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numInterval.Location = new Point(12, 288);
            numInterval.Maximum = new decimal(new int[] { 600000, 0, 0, 0 });
            numInterval.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numInterval.Name = "numInterval";
            numInterval.Size = new Size(82, 23);
            numInterval.TabIndex = 8;
            numInterval.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(12, 198);
            listBox.Name = "listBox";
            listBox.Size = new Size(143, 64);
            listBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.Location = new Point(4, 160);
            label4.Name = "label4";
            label4.Size = new Size(321, 35);
            label4.TabIndex = 11;
            label4.Text = "Do not monitor checks triggered by commits made by any author containing any of these strings in their name:";
            // 
            // addString
            // 
            addString.Location = new Point(226, 207);
            addString.Name = "addString";
            addString.Size = new Size(99, 23);
            addString.TabIndex = 12;
            // 
            // addButton
            // 
            addButton.Location = new Point(161, 207);
            addButton.Name = "addButton";
            addButton.Size = new Size(58, 23);
            addButton.TabIndex = 13;
            addButton.Text = "Add:";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(185, 236);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(113, 23);
            removeButton.TabIndex = 14;
            removeButton.Text = "Remove selected";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // SettingsForm
            // 
            ClientSize = new Size(337, 338);
            Controls.Add(saveButton);
            Controls.Add(numInterval);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(addString);
            Controls.Add(label4);
            Controls.Add(listBox);
            Controls.Add(label3);
            Controls.Add(infoButton);
            Controls.Add(apiKeyTextBox);
            Controls.Add(privateKeyRadio);
            Controls.Add(publicKeyRadio);
            Controls.Add(repoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            Text = "Github Pages Deploy Monitor";
            ((System.ComponentModel.ISupportInitialize)numInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private NumericUpDown numInterval;
        private Label label3;
        private ListBox listBox;
        private Label label4;
        private TextBox addString;
        private Button addButton;
        private Button removeButton;
    }
}