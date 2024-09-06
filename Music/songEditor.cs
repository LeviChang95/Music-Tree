using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Music.Program;

namespace Music
{
    public partial class songEditor : Form
    {
        public songEditor()
        {
            InitializeComponent();
            loadComponent();
            
        }

        Dictionary<CheckBox, Tag> checkBoxMap = new Dictionary<CheckBox, Tag>();
        List<CheckBox> checkBoxList = [];

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Song newSong = new(songTextBox.Text, artistTextBox.Text, "hello");
            List<Tag> confirmedTags = [];
            if (checkBoxList.Count == 0)
            {
                //Error out
            }
            for (int i = 0; i < checkBoxList.Count; i++)
            {
                if (checkBoxList[i].Checked)
                {
                    if (checkBoxMap.TryGetValue(checkBoxList[i], out Tag tag))
                        confirmedTags.Add(tag);
                }
            }

            if (editSong != null)
            {
                editSong = newSong;
                editSong = null;
            }
            newSong.addTags(confirmedTags.ToArray());
            this.Close();

            //refresh the page so tag goes

        }

        public void loadComponent()
        {
            for (int i = 0; i < allTags.Length; i++)
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
                
                for(int i = 0; i < editSong.tags.Count; i++)
                {
                    var checkBox = checkBoxMap.FirstOrDefault(x => x.Value == editSong.tags[i]);
                    checkBox.Key.Checked = true;  
                }
            }
        }
    }
}
