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
using static Music.Form1;

namespace Music
{
    public partial class tagEditor : Form
    {
        //--------------------INTIALIZE VARIABLES AND OBJECT--------------------
        public tagEditor()
        {
            InitializeComponent();
            loadComponent();
        }
        private void loadComponent()
        {
            for (int i = 0; i < allSongs.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = allSongs[i].name;
                checkBoxList.Add(checkBox);
                checkBoxMap.Add(checkBox, allSongs[i]);
                songCheckboxPanel.Controls.Add(checkBox);
            }

            if (editTag != null)
            {
                tagNameTextBox.Text = editTag.name;
                colourSquare.BackColor = editTag.colour;
                colourTextBox.Text = editTag.colour.ToString();
                for (int i = 0; i < editTag.songs.Count; i++)
                {
                    var checkBox = checkBoxMap.FirstOrDefault(x => x.Value == editTag.songs[i]);
                    checkBox.Key.Checked = true;
                }
            }
        }

        Dictionary<CheckBox, Song> checkBoxMap = new Dictionary<CheckBox, Song>();
        List<CheckBox> checkBoxList = [];

        //--------------------BUTTON ACTIONS--------------------

        private void confirmButton_Click(object sender, EventArgs e)
        {
            List<Song> confirmedSongs = [];

            for (int i = 0; i < checkBoxList.Count; i++)
            {
                if (checkBoxList[i].Checked)
                {
                    if (checkBoxMap.TryGetValue(checkBoxList[i], out Song song))
                        confirmedSongs.Add(song);
                }
            }

            if (editTag != null)
            {
                editTag.name = sanitizeText(tagNameTextBox.Text);
                editTag.colour = colourSquare.BackColor;
                editTag.remove();
                editTag.addSongs(confirmedSongs.ToArray());

            }
            else
            {
                Tag newTag = new(sanitizeText(tagNameTextBox.Text), colourSquare.BackColor);
                newTag.addSongs(confirmedSongs.ToArray());
                currentTag.addSubtag(newTag);
                allTags.Add(newTag);
            }

            this.Close();
            form1.refreshWindow();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colourConfirm_Click(object sender, EventArgs e)
        {
            colourSquare.BackColor = (Color)new ColorConverter().ConvertFromString(colourTextBox.Text);
        }
    }
}
