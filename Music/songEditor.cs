using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Music.Program;
using static Music.Form1;
using System.Media;

namespace Music
{
    public partial class songEditor : Form
    {
        //--------------------INTIALIZE VARIABLES AND OBJECT--------------------
        public songEditor()
        {
            InitializeComponent();
            loadComponent();
        }
        public void loadComponent()
        {
            for (int i = 1; i < allTags.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = allTags[i].name;
                checkBoxList.Add(checkBox);
                checkBoxMap.Add(checkBox, allTags[i]);
                tagCheckboxPanel.Controls.Add(checkBox);
            }

            if (editSong != null)
            {
                filenameLabel.Text = editSong.filePath;
                songTextBox.Text = editSong.name;
                artistTextBox.Text = editSong.artist;

                for (int i = 0; i < editSong.tags.Count; i++)
                {
                    if (editSong.tags[i] != root)
                    {
                        var checkBox = checkBoxMap.FirstOrDefault(x => x.Value == editSong.tags[i]);
                        checkBox.Key.Checked = true;
                    }
                }
            }
        }

        Dictionary<CheckBox, Tag> checkBoxMap = new Dictionary<CheckBox, Tag>();
        List<CheckBox> checkBoxList = [];

        //--------------------BUTTON ACTIONS--------------------

        private void confirmButton_Click(object sender, EventArgs e)
        {
            List<Tag> confirmedTags = [];
            
            for (int i = 0; i < checkBoxList.Count; i++)
            {
                if (checkBoxList[i].Checked)
                {
                    if (checkBoxMap.TryGetValue(checkBoxList[i], out Tag tag))
                        confirmedTags.Add(tag);
                }
            }
            if (confirmedTags.Count == 0)
                confirmedTags = [root];

            if (editSong != null)
            {
                bool wasRoot = (editSong.tags.Contains(root));
                editSong.name = sanitizeText(songTextBox.Text);
                editSong.artist = sanitizeText(artistTextBox.Text);
                editSong.filePath = filenameLabel.Text;
                editSong.remove();
                if (wasRoot)
                    editSong.addTags([root]);
                editSong.addTags(confirmedTags.ToArray());
            }
            else
            {
                Song newSong = new(sanitizeText(songTextBox.Text), sanitizeText(artistTextBox.Text), filenameLabel.Text);
                newSong.addTags(confirmedTags.ToArray());
                allSongs.Add(newSong);
            }

            this.Close();
            form1.refreshWindow();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filenameLabel.Text = dialog.FileName.ToString();
                    String path = Path.Combine(@"~\image");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var filename = System.IO.Path.GetFileName(dialog.FileName);
                    path = path + filename;
                    File.Copy(dialog.FileName, path);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
