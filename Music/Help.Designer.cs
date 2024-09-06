namespace Music
{
    partial class Help
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
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Consolas", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(284, 56);
            Title.TabIndex = 0;
            Title.Text = "Music Tree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 256);
            label1.Name = "label1";
            label1.Size = new Size(319, 15);
            label1.TabIndex = 1;
            label1.Text = "The centre panel contains Tags (larger) and Songs (smaller).";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 367);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 2;
            label2.Text = "Tags";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 403);
            label3.Name = "label3";
            label3.Size = new Size(421, 15);
            label3.TabIndex = 3;
            label3.Text = "Left Click plays every song under this tag and it's subtags and theirs recursivley";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 429);
            label4.Name = "label4";
            label4.Size = new Size(191, 15);
            label4.TabIndex = 4;
            label4.Text = "Left Double Click enters the subtag";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 454);
            label5.Name = "label5";
            label5.Size = new Size(311, 15);
            label5.TabIndex = 5;
            label5.Text = "Right Click opens a context menu to edit or delete the tag";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 478);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 6;
            label6.Text = "Songs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 75);
            label7.Name = "label7";
            label7.Size = new Size(106, 24);
            label7.TabIndex = 7;
            label7.Text = "Overview";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 280);
            label8.Name = "label8";
            label8.Size = new Size(442, 15);
            label8.TabIndex = 8;
            label8.Text = "Right Clicking on the centre panel opens a context menu to add new tags or songs";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 220);
            label9.Name = "label9";
            label9.Size = new Size(82, 24);
            label9.TabIndex = 9;
            label9.Text = "Basics";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 113);
            label10.Name = "label10";
            label10.Size = new Size(480, 15);
            label10.TabIndex = 10;
            label10.Text = "Whilst other music softwares categorise songs into playlists. This software seperates songs";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 139);
            label11.Name = "label11";
            label11.Size = new Size(472, 15);
            label11.TabIndex = 11;
            label11.Text = "into increasingly specific subgenres using tags. This allows users fine control over music.";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 166);
            label12.Name = "label12";
            label12.Size = new Size(488, 15);
            label12.TabIndex = 12;
            label12.Text = "For example, the category \"summer\" could be divided into \"beach\", \"nostalgia\" and \"party\"";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 192);
            label13.Name = "label13";
            label13.Size = new Size(496, 15);
            label13.TabIndex = 13;
            label13.Text = "Beach could be further divided into \"Sunbathing\", \"Vibes\" and \"BBQ MIX\" so on and so forth.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 308);
            label14.Name = "label14";
            label14.Size = new Size(402, 15);
            label14.TabIndex = 14;
            label14.Text = "The bottom panel is used to play, pause, skip or rewind to a previous song. ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 335);
            label15.Name = "label15";
            label15.Size = new Size(457, 15);
            label15.TabIndex = 15;
            label15.Text = "Clicking or dragging a song into the darker border exists a subtag and joins it's parent";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 516);
            label16.Name = "label16";
            label16.Size = new Size(325, 15);
            label16.TabIndex = 16;
            label16.Text = "Left Click Drag allows a song to be moved to another subtag";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 545);
            label17.Name = "label17";
            label17.Size = new Size(320, 15);
            label17.TabIndex = 17;
            label17.Text = "Right Click opens a context menu to edit or delete the song";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 583);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Help";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}