using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Linq;
using System.IO;
using System.Media;
using static Music.Program;

namespace Music
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            LoadData();

            RunFunctions();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }

        public static Tag[] allTags = [];
        public static Song[] allSongs = [];
        public static Song? editSong = null;

        public class Song
        {
            public string name;
            public string artist;
            public string filePath;
            public SoundPlayer track;
            public List<Tag> tags = [];

            public Song(string songName, string songArtist, string songFile)
            {
                name = songName;
                artist = songArtist;
                filePath = songFile;
                track = new SoundPlayer(songFile);
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

            public void playTrack() { track.Play(); }
            public void pauseTrack() { track.Stop(); }

            public void remove()
            {
                for(int i = 0; i < tags.Count; i++)
                {
                    tags[i].songs.Remove(this);
                }
            }
        }

        public class Tag
        {
            public string name;
            public Tag parent;
            public List<Tag> subtags = [];
            public List<Song> songs = [];

            public Tag(string tagName)
            {
                name = tagName;
            }

            public Tag(string tagName, List<Tag> tagSubtags, List<Song> tagSongs)
            {
                name = tagName;
                subtags = tagSubtags;
                for (int i = 0; i < tagSubtags.Count; i++)
                    tagSubtags[i].parent = this;
                songs = tagSongs;
            }

            // Return list containing all subtags and their subtags and so on
            public List<Tag> getTags()
            {
                List<Tag> tempList = [];
                return (getTagsHelper(tempList));
            }
            private List<Tag> getTagsHelper(List<Tag> list)
            {
                for (int i = 0; i < subtags.Count; i++)
                    list.Add(subtags[i]);
                for (int i = 0; i < subtags.Count; i++)
                    list.Concat(subtags[i].getTagsHelper(list));
                return list;
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

            public String getSongNames()
            {
                List<Song> list = this.getSongs();
                String nameList = "";
                if (list.Count != 0)
                {
                    nameList = nameList + list[0].name;
                    for (int i = 1; i < list.Count; i++)
                        nameList = nameList + ", " + list[i].name;
                    return nameList;
                }
                else
                    return nameList;
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
                
            }

            public void safeDelete()
            {
                
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].tags.Count == 1)
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

            }

        }

        static Song song001 = new("I bet on losing dogs", "Mitski", "mp3");
        static Song song002 = new("Your best american girl", "Mitski", "mp3");
        static Song song003 = new("First love/late spring", "Mitski", "mp3");
        static Song song004 = new("Apocalypse", "Cigarettes After Sex", "mp3");
        static Song song005 = new("Sunsetz", "Cigarettes After Sex", "mp3");

        public static Tag root = new("root");
        static Tag sad = new("sad");
        static Tag happy = new("happy");
        static Tag other = new("other");
        static Tag excited = new("excited");

        static void RunFunctions()
        {
            root.addSubtag(happy);
            root.addSubtag(sad);
            root.addSubtag(other);
            happy.addSubtag(excited);
            happy.addSongs([song001]);
            song002.addTags([other]);
            sad.addSongs([song003]);
            song004.addTags([excited]);
            song005.addTags([happy]);
            song003.addTags([happy]);
            allTags = [sad,happy,other,excited];

            happy.forceRemove();

            string placeholder = root.getSongNames();
        }

        static void LoadData()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\mdela\\source\\repos\\Music\\Music\\SavedData.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}