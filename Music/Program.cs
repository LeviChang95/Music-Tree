using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Linq;
using System.IO;
using System.Media;
using static Music.Program;
using System.Drawing.Text;

namespace Music
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            LoadData();
            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            Application.Run(form1);
        }

        //--------------------INTIALIZE VARIABLES--------------------

        public static Tag root = new("root", Color.Gray);
        public static List<Tag> allTags = [root];
        public static List<Song> allSongs = [];
        public static Song? editSong = null;
        public static Tag? editTag = null;
        public static Form1 form1 = null;
        public static Tag currentTag = root;

        public static String songDataPath = @"..\..\..\songData.txt";
        public static String tagDataPath = @"..\..\..\tagData.txt";

        //--------------------SONG Class--------------------

        public class Song
        {
            public string name;
            public string artist;
            public string filePath;
            public List<Tag> tags = [];

            public Song(string songName, string songArtist, string songFile)
            {
                name = songName;
                artist = songArtist;
                filePath = songFile;
            }

            public void addTags(Tag[] tagList)
            {
                for (int i = 0; i < tagList.Length; i++)
                {
                    if (!tags.Contains(tagList[i]))
                    {
                        tags.Add(tagList[i]);
                        tagList[i].addSongHelper(this);
                    }
                }
            }

            public void addTagHelper(Tag tag)
            {
                tags.Add(tag);
            }

            public void remove()
            {
                for(int i = 0; i < tags.Count; i++)
                {
                    tags[i].songs.Remove(this);
                }
                tags = [];
            }
        }

        //--------------------TAG CLASS--------------------

        public class Tag
        {
            public string name;
            public Tag parent;
            public List<Tag> subtags = [];
            public List<Song> songs = [];
            public Color colour = Color.Gray;

            public Tag(string tagName, Color tagColour)
            {
                name = tagName;
                colour = tagColour;
            }

            public void addSubtag(Tag subtag)
            {
                subtag.parent = this;
                subtags.Add(subtag);
            }

            public void addSongs(Song[] songList)
            {             
                for(int i = 0; i < songList.Length; i++)
                {
                    if (!songs.Contains(songList[i]))
                    {
                        songs.Add(songList[i]);
                        songList[i].addTagHelper(this);
                    }
                }
            }

            public void addSongHelper(Song song)
            {
                songs.Add(song);
            }

            public List<Song> getSongs()
            {
                List<Song> tempList = [];
                return (removeDuplicates(getSongsHelper(tempList)));
            }

            private List<Song> getSongsHelper(List<Song> list)
            {
                for (int i = 0; i < songs.Count; i++)
                    list.Add(songs[i]);
                for (int i = 0; i < subtags.Count; i++)
                    list.Concat(subtags[i].getSongsHelper(list));
                return list;
            }

            private List<Song> removeDuplicates(List<Song> list)
            {
                List<Song> tempList = [];
                for(int i = 0; i < list.Count; i++)
                {
                    if (!tempList.Contains(list[i]))
                        tempList.Add(list[i]);
                }
                return tempList;
            }
            
            public void cascadeDelete()
            {
                for (int i = 0; i < subtags.Count; i++)
                {
                    subtags[i].cascadeDelete();
                }
                for (int i = 0; i < songs.Count; i++)
                {
                    
                    if (songs[i].tags.Count == 1)
                        parent.addSongs([songs[i]]);
                    songs[i].tags.Remove(this);    
                }
                songs = [];
                subtags = [];
                parent.subtags.Remove(this);
                allTags.Remove(this);   
            }

            public void safeDelete()
            {
                
                for (int i = 0; i < songs.Count; i++)
                {
                    parent.addSongs([songs[i]]);
                    songs[i].tags.Remove(this);
                }
                for (int i = 0; i < subtags.Count; i++)
                {
                    parent.addSubtag(subtags[i]);
                }
                songs = [];
                subtags = [];
                parent.subtags.Remove(this);
                allTags.Remove(this);


            }

            public void remove()
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    songs[i].tags.Remove(this);
                }
                songs = [];
            }
        }

        //--------------------LOAD AND SAVE DATA--------------------

        static void LoadData()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(tagDataPath);
                
                line = sr.ReadLine();

                String[] tagSubtag = line.Split("|");
                String[] subtags = tagSubtag[1].Split(",");
                String[] nameColour = [];

                for (int i = 0; i < subtags.Length; i++)
                {
                    nameColour = subtags[i].Split("*");
                    Tag newTag = new Tag(nameColour[0], (Color)new ColorConverter().ConvertFromString(nameColour[1]));
                    root.addSubtag(newTag);
                    allTags.Add(newTag);
                }
                line = sr.ReadLine();
                
                while (line != null)
                {
                    tagSubtag = line.Split("|");
                    Tag parent = null;
                    
                    for (int i = 0; i < allTags.Count; i++)
                    {
                        if (allTags[i].name == tagSubtag[0])
                        {
                            parent = allTags[i];
                            break;
                        }
                    }

                    subtags = tagSubtag[1].Split(",");
                    for (int i = 0; i < subtags.Length; i++)
                    {
                        nameColour = subtags[i].Split("*");
                        Tag newTag = new Tag(nameColour[0], (Color)new ColorConverter().ConvertFromString(nameColour[1]));
                        parent.addSubtag(newTag);
                        allTags.Add(newTag);
                    }
                    line = sr.ReadLine();
                }
                
                sr.Close();
                Console.ReadLine();

                sr = new StreamReader(songDataPath);
                
                line = sr.ReadLine();

                readLineSong(line);
                line = sr.ReadLine();
                
                while (line != null){
                    readLineSong(line);
         
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();

            }
            
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void readLineSong(String line)
        {
            String[] parts = line.Split("|");
            String[] tags = parts[3].Split(",");
            Tag[] newTags = new Tag[tags.Length];

            for (int i = 0; i < tags.Length; i++)
            {
                int num = Convert.ToInt32(tags[i]);
                newTags[i] = (allTags[num]);
            }

            Song newSong = new Song(parts[0], parts[1], parts[2]);
            newSong.addTags(newTags);
            allSongs.Add(newSong);
        }

        public static void SaveData()
        {
            File.WriteAllText(songDataPath, "");
            using (StreamWriter writer = new StreamWriter(songDataPath))
            {
                for(int i = 0; i < allSongs.Count; i++)
                {
                    Song oldSong = allSongs[i];
                    String line = oldSong.name + "|" + oldSong.artist + "|" + oldSong.filePath + "|";
                    for(int j = 0; j < oldSong.tags.Count; j++)
                    {
                        line += allTags.IndexOf(oldSong.tags[j]) + ",";
                    }
                    if (line.EndsWith(","))
                        line = line.Remove(line.Length-1);
                    writer.WriteLine(line);
                }
            }

            File.WriteAllText(tagDataPath, "");
            using (StreamWriter writer = new StreamWriter(tagDataPath))
            {

                tagSaveDataHelper(writer, root);

            }
        }

        static void tagSaveDataHelper(StreamWriter writer,Tag tag)
        {
            String line = tag.name+ "|";
            for (int i = 0; i < tag.subtags.Count; i++)
            {
                line += tag.subtags[i].name + "*" + tag.subtags[i].colour.Name + ",";
            }
            if (line.EndsWith(","))
                line = line.Remove(line.Length - 1);
            writer.WriteLine(line);

            for (int i = 0; i < tag.subtags.Count; i++)
            {
                if (tag.subtags[i].subtags.Count != 0)
                    tagSaveDataHelper(writer, tag.subtags[i]);
            }
        }

        public static String sanitizeText(String text)
        {
            text.Replace("|", " ");
            text.Replace("*", " ");
            return text;
        }

    }
}