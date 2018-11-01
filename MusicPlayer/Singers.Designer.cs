namespace MusicPlayer
{
    partial class Singers
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
            this.SingersListBox = new System.Windows.Forms.ListBox();
            this.SongsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(667, 38);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(367, 40);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 21);
            this.Genre.TabIndex = 9;
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(510, 38);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(121, 23);
            this.Album.TabIndex = 8;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.Click += new System.EventHandler(this.Album_Click);
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(220, 38);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(121, 23);
            this.Favorite.TabIndex = 7;
            this.Favorite.Text = "My Favorite Songs";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Singer
            // 
            this.Singer.Enabled = false;
            this.Singer.Location = new System.Drawing.Point(71, 38);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(121, 23);
            this.Singer.TabIndex = 6;
            this.Singer.Text = "Singer";
            this.Singer.UseVisualStyleBackColor = true;
            // 
            // SingersListBox
            // 
            this.SingersListBox.FormattingEnabled = true;
            this.SingersListBox.Location = new System.Drawing.Point(173, 134);
            this.SingersListBox.Name = "SingersListBox";
            this.SingersListBox.Size = new System.Drawing.Size(168, 212);
            this.SingersListBox.TabIndex = 11;
            // 
            // SongsListBox
            // 
            this.SongsListBox.FormattingEnabled = true;
            this.SongsListBox.Location = new System.Drawing.Point(510, 134);
            this.SongsListBox.Name = "SongsListBox";
            this.SongsListBox.Size = new System.Drawing.Size(168, 212);
            this.SongsListBox.TabIndex = 12;
            // 
            // Singers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.SongsListBox);
            this.Controls.Add(this.SingersListBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.Singer);
            this.Name = "Singers";
            this.Text = "Singers";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button Singer;
        private System.Windows.Forms.ListBox SingersListBox;
        private System.Windows.Forms.ListBox SongsListBox;
    }
}