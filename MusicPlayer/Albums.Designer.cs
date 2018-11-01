namespace MusicPlayer
{
    partial class Albums
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Search = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Album = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Button();
            this.Singer = new System.Windows.Forms.Button();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(639, 57);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(339, 59);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 21);
            this.Genre.TabIndex = 14;
            // 
            // Album
            // 
            this.Album.Enabled = false;
            this.Album.Location = new System.Drawing.Point(482, 57);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(121, 23);
            this.Album.TabIndex = 13;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(192, 57);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(121, 23);
            this.Favorite.TabIndex = 12;
            this.Favorite.Text = "My Favorite Songs";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(43, 57);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(121, 23);
            this.Singer.TabIndex = 11;
            this.Singer.Text = "Singer";
            this.Singer.UseVisualStyleBackColor = true;
            this.Singer.Click += new System.EventHandler(this.Singer_Click);
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.FormattingEnabled = true;
            this.AlbumListBox.Location = new System.Drawing.Point(180, 142);
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.Size = new System.Drawing.Size(156, 199);
            this.AlbumListBox.TabIndex = 16;
            this.AlbumListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SongListBox
            // 
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.Location = new System.Drawing.Point(482, 142);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(156, 199);
            this.SongListBox.TabIndex = 17;
            // 
            // Albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.SongListBox);
            this.Controls.Add(this.AlbumListBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.Singer);
            this.Name = "Albums";
            this.Text = "Albums";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button Singer;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.ListBox SongListBox;
    }
}