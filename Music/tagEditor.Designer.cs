namespace Music
{
    partial class tagEditor
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
            tagNameTextBox = new TextBox();
            confirmButton = new Button();
            cancelButton = new Button();
            songCheckboxPanel = new FlowLayoutPanel();
            colourTextBox = new TextBox();
            colourSquare = new Panel();
            colourConfirm = new Button();
            SuspendLayout();
            // 
            // tagNameTextBox
            // 
            tagNameTextBox.Location = new Point(12, 12);
            tagNameTextBox.Name = "tagNameTextBox";
            tagNameTextBox.Size = new Size(326, 23);
            tagNameTextBox.TabIndex = 0;
            tagNameTextBox.Text = "Tag Name";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(266, 208);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(185, 208);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // songCheckboxPanel
            // 
            songCheckboxPanel.Location = new Point(12, 70);
            songCheckboxPanel.Name = "songCheckboxPanel";
            songCheckboxPanel.Size = new Size(326, 132);
            songCheckboxPanel.TabIndex = 3;
            // 
            // colourTextBox
            // 
            colourTextBox.Location = new Point(43, 41);
            colourTextBox.Name = "colourTextBox";
            colourTextBox.Size = new Size(217, 23);
            colourTextBox.TabIndex = 4;
            // 
            // colourSquare
            // 
            colourSquare.Location = new Point(12, 40);
            colourSquare.Name = "colourSquare";
            colourSquare.Size = new Size(25, 25);
            colourSquare.TabIndex = 5;
            // 
            // colourConfirm
            // 
            colourConfirm.Location = new Point(263, 41);
            colourConfirm.Name = "colourConfirm";
            colourConfirm.Size = new Size(75, 23);
            colourConfirm.TabIndex = 6;
            colourConfirm.Text = "Recolour";
            colourConfirm.UseVisualStyleBackColor = true;
            colourConfirm.Click += colourConfirm_Click;
            // 
            // tagEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 243);
            Controls.Add(colourConfirm);
            Controls.Add(colourSquare);
            Controls.Add(colourTextBox);
            Controls.Add(songCheckboxPanel);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(tagNameTextBox);
            Name = "tagEditor";
            Text = "tagEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tagNameTextBox;
        private Button confirmButton;
        private Button cancelButton;
        private FlowLayoutPanel songCheckboxPanel;
        private TextBox colourTextBox;
        private Panel colourSquare;
        private Button colourConfirm;
    }
}