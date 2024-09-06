namespace Music
{
    partial class songEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addSongPanel = new Panel();
            cancelButton = new Button();
            confirmButton = new Button();
            artistTextBox = new TextBox();
            filenameLabel = new Label();
            tagCheckboxPanel = new FlowLayoutPanel();
            songTextBox = new TextBox();
            uploadButton = new Button();
            addSongPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addSongPanel
            // 
            addSongPanel.Controls.Add(cancelButton);
            addSongPanel.Controls.Add(confirmButton);
            addSongPanel.Controls.Add(artistTextBox);
            addSongPanel.Controls.Add(filenameLabel);
            addSongPanel.Controls.Add(tagCheckboxPanel);
            addSongPanel.Controls.Add(songTextBox);
            addSongPanel.Controls.Add(uploadButton);
            addSongPanel.Location = new Point(10, 9);
            addSongPanel.Margin = new Padding(3, 2, 3, 2);
            addSongPanel.Name = "addSongPanel";
            addSongPanel.Size = new Size(389, 217);
            addSongPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(226, 182);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(65, 22);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(296, 182);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(69, 22);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(226, 38);
            artistTextBox.Margin = new Padding(3, 2, 3, 2);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(140, 23);
            artistTextBox.TabIndex = 5;
            artistTextBox.Text = "Artist Name";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(81, 14);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(25, 15);
            filenameLabel.TabIndex = 4;
            filenameLabel.Text = "File";
            // 
            // tagCheckboxPanel
            // 
            tagCheckboxPanel.Location = new Point(14, 71);
            tagCheckboxPanel.Margin = new Padding(3, 2, 3, 2);
            tagCheckboxPanel.Name = "tagCheckboxPanel";
            tagCheckboxPanel.Size = new Size(351, 103);
            tagCheckboxPanel.TabIndex = 3;
            // 
            // songTextBox
            // 
            songTextBox.Location = new Point(14, 38);
            songTextBox.Margin = new Padding(3, 2, 3, 2);
            songTextBox.Name = "songTextBox";
            songTextBox.Size = new Size(207, 23);
            songTextBox.TabIndex = 1;
            songTextBox.Text = "Song Name";
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(14, 11);
            uploadButton.Margin = new Padding(3, 2, 3, 2);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(62, 22);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // songEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 240);
            Controls.Add(addSongPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "songEditor";
            Text = "songEditor";
            addSongPanel.ResumeLayout(false);
            addSongPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addSongPanel;
        private Button cancelButton;
        private Button confirmButton;
        private TextBox artistTextBox;
        private Label filenameLabel;
        private FlowLayoutPanel tagCheckboxPanel;
        private TextBox songTextBox;
        private Button uploadButton;
    }
}