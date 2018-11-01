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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Singer_Click(object sender, EventArgs e)
        {
            Singers singers = new Singers();
            singers.Show();
            this.Hide();
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

        private void GoToPlayer_Click(object sender, EventArgs e)
        {
            var playerForm = new Form1();
            playerForm.Show();
            this.Hide();
        }

        private void Genre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
