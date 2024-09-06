using System.Xml.Linq;
using System.Media;
using static Music.Program;
using System.Drawing.Text;
using System.Windows.Forms;



namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            enterSubtag(root);
            helpPopup();
        }

        //--------------------KEY FUCNTIONS--------------------

        Dictionary<Button, Tag> tagMap = new Dictionary<Button, Tag>();
        Dictionary<Button, Song> songMap = new Dictionary<Button, Song>();

        private void enterSubtag(Tag tag)
        {
            if (tag == null)
                return;
            rootFlowLayoutPanel.Controls.Clear();

            for (int i = 0; i < tag.subtags.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = tag.subtags[i].name;
                newButton.MouseClick += tagButton_Click;
                newButton.DragEnter += song_DragEnter;
                newButton.DragDrop += tagButton_DragDrop;
                newButton.AllowDrop = true;
                newButton.BackColor = tag.subtags[i].colour;
                newButton.Padding = new Padding(10);
                newButton.Font = new System.Drawing.Font("Consolas", 20F);
                newButton.FlatAppearance.BorderSize = 5;
                newButton.ContextMenuStrip = tagButtonContext;
                newButton.AutoSize = true;
                newButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tagMap.Add(newButton, tag.subtags[i]);
                rootFlowLayoutPanel.Controls.Add(newButton);
            }
            for (int i = 0; i < tag.songs.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = tag.songs[i].name;
                newButton.MouseUp += songButton_MouseUp;
                newButton.MouseMove += songButton_MouseMove;
                newButton.BackColor = tag.colour;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.Padding = new Padding(5);
                newButton.Font = new System.Drawing.Font("Consolas", 10F);
                newButton.ContextMenuStrip = songButtonContext;
                newButton.AutoSize = true;
                newButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                songMap.Add(newButton, tag.songs[i]);
                rootFlowLayoutPanel.Controls.Add(newButton);
            }

            currentTag = tag;
            titleLabel.Text = currentTag.name;
            if (currentTag == root)
                titleLabel.Text = "Home";

        }

        private void backPanel_Click(object sender, EventArgs e)
        {
            enterSubtag(currentTag.parent);
        }

        public void refreshWindow()
        {
            moveOriginTag = null;
            clickCount = 0;
            editSong = null;
            editTag = null;
            enterSubtag(currentTag);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveData();
        }

        //--------------------HELP POPUP--------------------

        private void helpPopup()
        {
            Help alert = new();
            alert.Show();
        }
        
        private void helpButton_Click(object sender, EventArgs e)
        {
            helpPopup();
        }

        //--------------------HOT BAR CONTROLS--------------------

        private void pauseplaySong_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                player.Ctlcontrols.pause();
                isPlaying = false;

                pauseplayButton.Image = Image.FromFile(@"Images\play.png");

            }
            else
            {
                player.Ctlcontrols.play();
                isPlaying = true;

                pauseplayButton.Image = Image.FromFile(@"Images\pause.png");

            }

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            queue = [];
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (queueIndex != (queue.Count - 1))
            {
                queueIndex++;
                player.URL = queue[queueIndex].filePath;
            }
            else
            {
                queueIndex = 0;
                player.URL = queue[queueIndex].filePath;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (queueIndex > 0)
            {
                queueIndex--;
                player.URL = queue[queueIndex].filePath;
            }

            else
            {
                queueIndex = queue.Count - 1;
                player.URL = queue[queueIndex].filePath;
            }
        }


        //--------------------PAUSE AND PLAY--------------------

        bool isPlaying = true;
        private List<Song> queue = [];
        private int queueIndex = 0;
        private System.Timers.Timer Timer;

        async void tagButton_Click(object sender, MouseEventArgs e)
        {
            if (clickCount > 0)
            {
                clickCount = 2;
                return;
            }
            clickCount = 1;
            await Task.Delay(SystemInformation.DoubleClickTime);

            if (clickCount == 1)
            {
                queue = [];
                if (tagMap.TryGetValue((Button)sender, out Tag tag))
                {
                    queue = tag.getSongs();
                    playQueue();
                }
            }
            else if (clickCount == 2)
            {
                if (tagMap.TryGetValue((Button)sender, out Tag tag))
                    enterSubtag(tag);
            }
            clickCount = 0;
        }

        private void playQueue()
        {
            isPlaying = true;
            pauseplayButton.Image = Image.FromFile(@"Images\pause.png");
            queueIndex = 0;
            timer.Start();

            var firstSong = queue[queueIndex];
            if (firstSong == null)
                return;
            player.URL = firstSong.filePath;

        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                songProgress.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                songProgress.Value = (int)player.Ctlcontrols.currentPosition;
            }
            timerStartLabel.Text = player.Ctlcontrols.currentPositionString;
            timerEndLabel.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            if (player.Ctlcontrols.currentPosition < player.Ctlcontrols.currentItem.duration &&
                player.Ctlcontrols.currentPosition > player.Ctlcontrols.currentItem.duration - 2)
            {
                queueIndex++;
                if (queueIndex == queue.Count - 1)
                    queueIndex = 0;
                player.URL = queue[queueIndex].filePath;
                player.Ctlcontrols.play();
            }
        }

        //--------------------SONG MENU--------------------

        Control _sourceControl = null;

        private void songToolStripMenuItem_Open(object sender, EventArgs e)
        {
            _sourceControl = songButtonContext.SourceControl;
            if (songMap.TryGetValue((Button)_sourceControl, out Song song))
                editSong = song;
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songEditor alert = new();
            alert.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songEditor alert = new();
            alert.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editSong.tags.Count == 1)
            {
                if (editSong.tags[0] == root)
                    return;
                editSong.addTags([root]);
            }
            currentTag.songs.Remove(editSong);
            editSong.tags.Remove(currentTag);
            refreshWindow();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editSong.remove();
            allSongs.Remove(editSong);
            refreshWindow();
        }

        //--------------------TAG MENU--------------------

        private void tagToolStripMenuItem_Open(object sender, EventArgs e)
        {
            _sourceControl = tagButtonContext.SourceControl;
            if (tagMap.TryGetValue((Button)_sourceControl, out Tag tag))
                editTag = tag;
        }

        private void addTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tagEditor alert = new();
            alert.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tagEditor alert = new();
            alert.Show();
        }

        private void safeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTag.safeDelete();
            refreshWindow();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTag.cascadeDelete();
            refreshWindow();
        }

        //--------------------DRAG AND DROP--------------------

        Tag moveOriginTag = null;

        public int clickCount = 0;

        private void songButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveOriginTag = currentTag;
                Button btn = (Button)sender;
                btn.DoDragDrop(btn, DragDropEffects.Copy |
                   DragDropEffects.Move);
            }
        }

        private void songButton_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                clickCount++;
                if (clickCount > 5)
                {
                    moveOriginTag = currentTag;
                    btn.DoDragDrop(btn, DragDropEffects.Copy |
                       DragDropEffects.Move);
                }
            }
        }

        private void songButton_MouseUp(object sender, MouseEventArgs e)
        {
            clickCount = 0;
        }

        private void song_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(Button)))
            {
                Button item = (Button)e.Data.GetData(typeof(Button));
                e.Effect = (DragDropEffects.Copy);
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void tagButton_DragDrop(object sender, DragEventArgs e)
        {
            clickCount = 0;
            Button songButton = (Button)e.Data.GetData(typeof(Button));
            if (tagMap.TryGetValue((Button)sender, out Tag tag))
            {

                if (songMap.TryGetValue(songButton, out Song song))
                {
                    tag.addSongs([song]);
                    if (moveOriginTag != null)
                    {
                        moveOriginTag.songs.Remove(song);
                        song.tags.Remove(moveOriginTag);
                    }
                    else
                    {
                        tag.parent.songs.Remove(song);
                        song.tags.Remove(tag.parent);
                    }
                    refreshWindow();
                }
            }

        }

        private void panelButton_DragDrop(object sender, DragEventArgs e)
        {
            if (currentTag != moveOriginTag)
            {
                Button songButton = (Button)e.Data.GetData(typeof(Button));
                if (songMap.TryGetValue(songButton, out Song song))
                {
                    currentTag.addSongs([song]);
                    moveOriginTag.songs.Remove(song);
                    song.tags.Remove(moveOriginTag);
                    refreshWindow();
                }
            }
        }

        private void songBack_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                Button item = (Button)e.Data.GetData(typeof(Button));
                e.Effect = (DragDropEffects.Copy);
            }
            else
                e.Effect = DragDropEffects.None;
            enterSubtag(currentTag.parent);
        }

        private void backPanel_DragDrop(object sender, DragEventArgs e)
        {
            clickCount = 0;
        }

        //--------------------FUTURE METHODS--------------------

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            String text = "searchTextBox.Text";
            List<Song> songNameList = [];
            List<Song> songArtistList = [];
            List<Tag> tagNameList = [];
            for (int i = 0; i < allSongs.Count; i++)
            {
                if (allSongs[i].name.Contains(text))
                    songNameList.Add(allSongs[i]);
                if (allSongs[i].artist.Contains(text))
                    songArtistList.Add(allSongs[i]);
            }
            for (int i = 0; i < allTags.Count; i++)
            {
                if (allTags[i].name.Contains(text))
                    tagNameList.Add(allTags[i]);
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            //Randomise the queue
            //Save the previously played songs in a list for use of the previous button
        }

        
    }
}
