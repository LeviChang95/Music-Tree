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
            navbarPanel = new Panel();
            settingsButton = new Button();
            searchTextBox = new TextBox();
            rootFlowLayoutPanel = new FlowLayoutPanel();
            button1 = new Button();
            toolbarPanel = new Panel();
            addSongButton = new Button();
            nextButton = new Button();
            previousButton = new Button();
            shuffleButton = new Button();
            loopButton = new Button();
            pauseplayButton = new Button();
            songButtonContext = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            navbarPanel.SuspendLayout();
            rootFlowLayoutPanel.SuspendLayout();
            toolbarPanel.SuspendLayout();
            songButtonContext.SuspendLayout();
            SuspendLayout();
            // 
            // navbarPanel
            // 
            navbarPanel.Controls.Add(settingsButton);
            navbarPanel.Controls.Add(searchTextBox);
            navbarPanel.Location = new Point(76, 12);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(715, 42);
            navbarPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(630, 7);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(79, 29);
            settingsButton.TabIndex = 1;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(9, 8);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(385, 27);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search";
            // 
            // rootFlowLayoutPanel
            // 
            rootFlowLayoutPanel.Controls.Add(button1);
            rootFlowLayoutPanel.Location = new Point(76, 53);
            rootFlowLayoutPanel.Name = "rootFlowLayoutPanel";
            rootFlowLayoutPanel.Size = new Size(176, 385);
            rootFlowLayoutPanel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enterSubtag_Click;
            // 
            // toolbarPanel
            // 
            toolbarPanel.Controls.Add(addSongButton);
            toolbarPanel.Controls.Add(nextButton);
            toolbarPanel.Controls.Add(previousButton);
            toolbarPanel.Controls.Add(shuffleButton);
            toolbarPanel.Controls.Add(loopButton);
            toolbarPanel.Controls.Add(pauseplayButton);
            toolbarPanel.Location = new Point(12, 12);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(67, 426);
            toolbarPanel.TabIndex = 3;
            // 
            // addSongButton
            // 
            addSongButton.Location = new Point(8, 358);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(55, 55);
            addSongButton.TabIndex = 6;
            addSongButton.Text = "+";
            addSongButton.UseVisualStyleBackColor = true;
            addSongButton.Click += addSongButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(11, 247);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(40, 40);
            nextButton.TabIndex = 5;
            nextButton.Text = "D";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(11, 144);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(40, 40);
            previousButton.TabIndex = 4;
            previousButton.Text = "^";
            previousButton.UseVisualStyleBackColor = true;
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(8, 293);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(45, 45);
            shuffleButton.TabIndex = 3;
            shuffleButton.Text = "<>";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // loopButton
            // 
            loopButton.Location = new Point(11, 93);
            loopButton.Name = "loopButton";
            loopButton.Size = new Size(45, 45);
            loopButton.TabIndex = 2;
            loopButton.Text = "( )";
            loopButton.UseVisualStyleBackColor = true;
            loopButton.Click += loopButton_Click;
            // 
            // pauseplayButton
            // 
            pauseplayButton.ImageAlign = ContentAlignment.TopRight;
            pauseplayButton.Location = new Point(8, 190);
            pauseplayButton.Name = "pauseplayButton";
            pauseplayButton.Size = new Size(50, 50);
            pauseplayButton.TabIndex = 0;
            pauseplayButton.Text = ">/=";
            pauseplayButton.UseVisualStyleBackColor = true;
            pauseplayButton.Click += pauseplaySong_Click;
            // 
            // songButtonContext
            // 
            songButtonContext.ImageScalingSize = new Size(20, 20);
            songButtonContext.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            songButtonContext.Name = "songButtonContext";
            songButtonContext.Size = new Size(211, 80);
            songButtonContext.Opened += songToolStripMenuItem_Open;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(210, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(210, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 454);
            Controls.Add(toolbarPanel);
            Controls.Add(rootFlowLayoutPanel);
            Controls.Add(navbarPanel);
            Name = "Form1";
            Text = "Form1";
            navbarPanel.ResumeLayout(false);
            navbarPanel.PerformLayout();
            rootFlowLayoutPanel.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            songButtonContext.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navbarPanel;
        private FlowLayoutPanel rootFlowLayoutPanel;
        private Panel toolbarPanel;
        private Button pauseplayButton;
        private Button shuffleButton;
        private Button loopButton;
        private Button previousButton;
        private Button nextButton;
        private Button addSongButton;
        private Button settingsButton;
        private TextBox searchTextBox;
        private Button button1;
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
    }
}
