using System.Xml.Linq;
using System.Media;
using static Music.Program;
using System.Drawing.Text;


namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tagMap.Add(button1, root);
        }

        Dictionary<Button, Tag> tagMap = new Dictionary<Button, Tag>();
        Dictionary<Button, Song> songMap = new Dictionary<Button, Song>();
        bool isPlaying = true;



        private void addSubtag(Tag tag)
        {
            Button myButton = new Button();
            myButton.Text = tag.name;
            //myButton.Click += ButtonClickHandler;
            rootFlowLayoutPanel.Controls.Add(myButton);
        }

        private void loopButton_Click(object sender, EventArgs e)
        {

        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {

        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            songEditor alert = new();
            alert.Show();
        }

        private void enterSubtag(Tag tag)
        {
            rootFlowLayoutPanel.Controls.Clear();
            //get subtag
            //FlowLayoutPanel newPanel = new FlowLayoutPanel();

            for (int i = 0; i < tag.subtags.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = tag.subtags[i].name;
                newButton.Click += enterSubtag_Click;
                newButton.BackColor = Color.Blue;
                tagMap.Add(newButton, tag.subtags[i]);
                rootFlowLayoutPanel.Controls.Add(newButton);
            }
            for (int i = 0; i < tag.songs.Count; i++)
            {
                Button newButton = new Button();
                newButton.Text = tag.songs[i].name;
                //myButton.Click += ButtonClickHandler;
                newButton.BackColor = Color.Red;
                newButton.ContextMenuStrip = songButtonContext;
                songMap.Add(newButton, tag.songs[i]);
                rootFlowLayoutPanel.Controls.Add(newButton);
            }

        }

        private void playSong(Song song)
        {
            song.playTrack();
        }

        private void pauseSong(Song song)
        {
            song.pauseTrack();
        }

        private void enterSubtag_Click(object sender, EventArgs e)
        {
            if (tagMap.TryGetValue((Button)sender, out Tag tag))
                enterSubtag(tag);
        }

        private void pauseplaySong_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                if (songMap.TryGetValue((Button)sender, out Song song))
                    pauseSong(song);
                isPlaying = false;
                pauseplayButton.Text = ">";
            }
            else
            {
                if (songMap.TryGetValue((Button)sender, out Song song))
                    playSong(song);
                isPlaying = true;
                pauseplayButton.Text = "=";
            }

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

        }

        private void tagsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {


        }

        Control _sourceControl = null;

        private void songToolStripMenuItem_Open(object sender, EventArgs e)
        {
            _sourceControl = songButtonContext.SourceControl;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (songMap.TryGetValue((Button)_sourceControl, out Song song))
                editSong = song;
            songEditor alert = new();
            alert.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
