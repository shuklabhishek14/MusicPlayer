using MusicPlayerData;
using MusicPlayerData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        
        public WMPLib.WindowsMediaPlayer wplayer;
        public string SongName = "";

        public Form1()
        {
            InitializeComponent();
            wplayer = new WMPLib.WindowsMediaPlayer();
        }

        private void myFavoriteSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MusicPlayerDataModel())
            {
                axWindowsMediaPlayer1.URL = context.Songs.FirstOrDefault().SongName;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(this.SongName) && this.SongName != "") // checks the file
                {

                    FileStream file = new FileStream(this.SongName, FileMode.Open, FileAccess.Read);
                    byte[] songdata = File.ReadAllBytes(this.SongName);
                    file.Close();

                    using (var context = new MusicPlayerDataModel())
                    {
                        context.Songs.Add(new Song
                        {
                            SongId = Guid.NewGuid(),
                            SongName = this.SongName,
                            ContentType = "Song",
                            Content = songdata,
                            Favorite = true,
                            Artist = "Vasu",
                            Album = "VasuAlbum",
                            Lyrics = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla eleifend sem eu nunc eleifend, id lacinia dolor consequat. Phasellus molestie, velit a congue elementum, tellus ante egestas massa, eget lobortis lorem sapien at risus. Etiam rhoncus, tellus eget iaculis iaculis, ex nisl aliquam enim, non porttitor orci neque eu lectus.",
                            Genre = "Pop"
                        });
                        context.SaveChanges();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void browse_Click(object sender, EventArgs e)
        {
            // Opens the mp3 files
            
            openFileDialog1.Filter = "Audio files | *.mp3";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.SongName = openFileDialog1.FileName;
            }

        }

        private List<string> GetGenres()
        {
            return new List<string>
            {
                "Rock", "Grunge", "PopMusic", "Jazz", "Folk", "Blues", "HipHop", "Classical", "Reggae", "Country"
            };
        }
    }
}
