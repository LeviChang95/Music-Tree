namespace Music
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            navbarPanel = new Panel();
            helpButton = new Button();
            titleLabel = new Label();
            player = new AxWMPLib.AxWindowsMediaPlayer();
            rootFlowLayoutPanel = new FlowLayoutPanel();
            panelContext = new ContextMenuStrip(components);
            addSongToolStripMenuItem = new ToolStripMenuItem();
            addTagToolStripMenuItem = new ToolStripMenuItem();
            toolbarPanel = new Panel();
            timerEndLabel = new Label();
            timerStartLabel = new Label();
            songProgress = new ProgressBar();
            nextButton = new Button();
            previousButton = new Button();
            pauseplayButton = new Button();
            songButtonContext = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            tagButtonContext = new ContextMenuStrip(components);
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            safeToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            backPanel = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panelContext.SuspendLayout();
            toolbarPanel.SuspendLayout();
            songButtonContext.SuspendLayout();
            tagButtonContext.SuspendLayout();
            backPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navbarPanel
            // 
            navbarPanel.BackColor = SystemColors.ControlDarkDark;
            navbarPanel.Controls.Add(helpButton);
            navbarPanel.Controls.Add(titleLabel);
            navbarPanel.Controls.Add(player);
            navbarPanel.Location = new Point(-1, -2);
            navbarPanel.Margin = new Padding(3, 2, 3, 2);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(536, 45);
            navbarPanel.TabIndex = 0;
            // 
            // helpButton
            // 
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Image = Properties.Resources.question_mark1;
            helpButton.Location = new Point(494, 8);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(31, 32);
            helpButton.TabIndex = 8;
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(13, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(74, 32);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Home";
            // 
            // player
            // 
            player.Enabled = true;
            player.Location = new Point(297, 8);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(231, 34);
            player.TabIndex = 7;
            player.Visible = false;
            // 
            // rootFlowLayoutPanel
            // 
            rootFlowLayoutPanel.AllowDrop = true;
            rootFlowLayoutPanel.BackColor = Color.Gray;
            rootFlowLayoutPanel.ContextMenuStrip = panelContext;
            rootFlowLayoutPanel.Location = new Point(26, 23);
            rootFlowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            rootFlowLayoutPanel.Name = "rootFlowLayoutPanel";
            rootFlowLayoutPanel.Size = new Size(484, 237);
            rootFlowLayoutPanel.TabIndex = 2;
            rootFlowLayoutPanel.DragDrop += panelButton_DragDrop;
            rootFlowLayoutPanel.DragEnter += song_DragEnter;
            // 
            // panelContext
            // 
            panelContext.Items.AddRange(new ToolStripItem[] { addSongToolStripMenuItem, addTagToolStripMenuItem });
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(127, 48);
            // 
            // addSongToolStripMenuItem
            // 
            addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            addSongToolStripMenuItem.Size = new Size(126, 22);
            addSongToolStripMenuItem.Text = "Add Song";
            addSongToolStripMenuItem.Click += addSongToolStripMenuItem_Click;
            // 
            // addTagToolStripMenuItem
            // 
            addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            addTagToolStripMenuItem.Size = new Size(126, 22);
            addTagToolStripMenuItem.Text = "Add Tag";
            addTagToolStripMenuItem.Click += addTagToolStripMenuItem_Click;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = SystemColors.ControlDarkDark;
            toolbarPanel.Controls.Add(timerEndLabel);
            toolbarPanel.Controls.Add(timerStartLabel);
            toolbarPanel.Controls.Add(songProgress);
            toolbarPanel.Controls.Add(nextButton);
            toolbarPanel.Controls.Add(previousButton);
            toolbarPanel.Controls.Add(pauseplayButton);
            toolbarPanel.Location = new Point(-1, 325);
            toolbarPanel.Margin = new Padding(3, 2, 3, 2);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(536, 98);
            toolbarPanel.TabIndex = 3;
            // 
            // timerEndLabel
            // 
            timerEndLabel.AutoSize = true;
            timerEndLabel.ForeColor = Color.White;
            timerEndLabel.Location = new Point(485, 56);
            timerEndLabel.Name = "timerEndLabel";
            timerEndLabel.Size = new Size(34, 15);
            timerEndLabel.TabIndex = 12;
            timerEndLabel.Text = "00:00";
            // 
            // timerStartLabel
            // 
            timerStartLabel.AutoSize = true;
            timerStartLabel.ForeColor = Color.White;
            timerStartLabel.Location = new Point(12, 56);
            timerStartLabel.Name = "timerStartLabel";
            timerStartLabel.Size = new Size(34, 15);
            timerStartLabel.TabIndex = 11;
            timerStartLabel.Text = "00:00";
            // 
            // songProgress
            // 
            songProgress.BackColor = Color.White;
            songProgress.ForeColor = Color.Gray;
            songProgress.Location = new Point(50, 58);
            songProgress.Name = "songProgress";
            songProgress.Size = new Size(424, 10);
            songProgress.TabIndex = 10;
            // 
            // nextButton
            // 
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Image = Properties.Resources.fast_forward;
            nextButton.Location = new Point(331, 7);
            nextButton.Margin = new Padding(3, 2, 3, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(44, 44);
            nextButton.TabIndex = 5;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Image = Properties.Resources.rewind;
            previousButton.Location = new Point(143, 9);
            previousButton.Margin = new Padding(3, 2, 3, 2);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(48, 40);
            previousButton.TabIndex = 4;
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // pauseplayButton
            // 
            pauseplayButton.FlatAppearance.BorderSize = 0;
            pauseplayButton.FlatStyle = FlatStyle.Flat;
            pauseplayButton.Image = Properties.Resources.play;
            pauseplayButton.ImageAlign = ContentAlignment.TopRight;
            pauseplayButton.Location = new Point(242, 3);
            pauseplayButton.Margin = new Padding(3, 2, 3, 2);
            pauseplayButton.Name = "pauseplayButton";
            pauseplayButton.Size = new Size(49, 48);
            pauseplayButton.TabIndex = 0;
            pauseplayButton.UseVisualStyleBackColor = true;
            pauseplayButton.Click += pauseplaySong_Click;
            // 
            // songButtonContext
            // 
            songButtonContext.ImageScalingSize = new Size(20, 20);
            songButtonContext.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, removeToolStripMenuItem, deleteToolStripMenuItem });
            songButtonContext.Name = "songButtonContext";
            songButtonContext.Size = new Size(118, 70);
            songButtonContext.Opened += songToolStripMenuItem_Open;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(117, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(117, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(117, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // tagButtonContext
            // 
            tagButtonContext.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem1, deleteToolStripMenuItem1 });
            tagButtonContext.Name = "tagButtonContext";
            tagButtonContext.Size = new Size(108, 48);
            tagButtonContext.Opened += tagToolStripMenuItem_Open;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(107, 22);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { safeToolStripMenuItem, cascadeToolStripMenuItem });
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(107, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // safeToolStripMenuItem
            // 
            safeToolStripMenuItem.Name = "safeToolStripMenuItem";
            safeToolStripMenuItem.Size = new Size(118, 22);
            safeToolStripMenuItem.Text = "Safe";
            safeToolStripMenuItem.Click += safeToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(118, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // backPanel
            // 
            backPanel.AllowDrop = true;
            backPanel.BackColor = Color.FromArgb(64, 64, 64);
            backPanel.Controls.Add(rootFlowLayoutPanel);
            backPanel.Location = new Point(-4, 41);
            backPanel.Name = "backPanel";
            backPanel.Size = new Size(633, 288);
            backPanel.TabIndex = 4;
            backPanel.Click += backPanel_Click;
            backPanel.DragDrop += backPanel_DragDrop;
            backPanel.DragEnter += songBack_DragEnter;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 418);
            Controls.Add(toolbarPanel);
            Controls.Add(backPanel);
            Controls.Add(navbarPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            navbarPanel.ResumeLayout(false);
            navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panelContext.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            songButtonContext.ResumeLayout(false);
            tagButtonContext.ResumeLayout(false);
            backPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navbarPanel;
        private FlowLayoutPanel rootFlowLayoutPanel;
        private Panel toolbarPanel;
        private Button pauseplayButton;
        private Button previousButton;
        private Button nextButton;
        private Panel addSongPanel;
        private Button uploadButton;
        private TextBox tagsTextBox;
        private TextBox songTextBox;
        private Label filenameLabel;
        private FlowLayoutPanel tagCheckboxPanel;
        private TextBox artistTextBox;
        private Button confirmButton;
        private Button cancelButton;
        private ContextMenuStrip songButtonContext;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip tagButtonContext;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem safeToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private Panel backPanel;
        private ContextMenuStrip panelContext;
        private ToolStripMenuItem addSongToolStripMenuItem;
        private ToolStripMenuItem addTagToolStripMenuItem;
        private Label titleLabel;
        private ToolStripMenuItem removeToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private ProgressBar songProgress;
        private Label timerStartLabel;
        private Label timerEndLabel;
        private System.Windows.Forms.Timer timer;
        private Button helpButton;
    }
}
