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
            addSongPanel.Location = new Point(12, 12);
            addSongPanel.Name = "addSongPanel";
            addSongPanel.Size = new Size(445, 289);
            addSongPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(258, 243);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(74, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(338, 243);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(79, 29);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(258, 51);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(159, 27);
            artistTextBox.TabIndex = 5;
            artistTextBox.Text = "Artist Name";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new Point(93, 19);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new Size(32, 20);
            filenameLabel.TabIndex = 4;
            filenameLabel.Text = "File";
            // 
            // tagCheckboxPanel
            // 
            tagCheckboxPanel.Location = new Point(16, 95);
            tagCheckboxPanel.Name = "tagCheckboxPanel";
            tagCheckboxPanel.Size = new Size(401, 137);
            tagCheckboxPanel.TabIndex = 3;
            // 
            // songTextBox
            // 
            songTextBox.Location = new Point(16, 50);
            songTextBox.Name = "songTextBox";
            songTextBox.Size = new Size(236, 27);
            songTextBox.TabIndex = 1;
            songTextBox.Text = "Song Name";
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(16, 15);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(71, 29);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Upload";
            uploadButton.UseVisualStyleBackColor = true;
            // 
            // songEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 320);
            Controls.Add(addSongPanel);
            FormBorderStyle = FormBorderStyle.None;
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