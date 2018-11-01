using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Singers : Form
    {
        public Singers()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This list box should have SingerName, SongName, YearOfRelease, Genre, Album
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            var favSongForm = new MyFavoriteSongs();
            favSongForm.Show();
            this.Hide();
        }

        private void Album_Click(object sender, EventArgs e)
        {
            var albumForm = new Albums();
            albumForm.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Searchs searchForm = new Searchs();
            searchForm.Show();
            this.Hide();
        }
    }
}
