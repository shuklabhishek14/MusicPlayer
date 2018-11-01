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
    public partial class MyFavoriteSongs : Form
    {
        public MyFavoriteSongs()
        {
            InitializeComponent();
        }

        private void MyFavoriteSongs_Load(object sender, EventArgs e)
        {
            //Load the list of Favorite Songs
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Singers singers = new Singers();
            singers.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlbumBtn_Click(object sender, EventArgs e)
        {
            var albumForm = new Albums();
            albumForm.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Searchs searchForm = new Searchs();
            searchForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
