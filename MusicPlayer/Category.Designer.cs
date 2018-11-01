namespace MusicPlayer
{
    partial class Category
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
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(641, 78);
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
            this.Genre.Location = new System.Drawing.Point(341, 80);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 21);
            this.Genre.TabIndex = 9;
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(484, 78);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(121, 23);
            this.Album.TabIndex = 8;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.Click += new System.EventHandler(this.Album_Click);
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(194, 78);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(121, 23);
            this.Favorite.TabIndex = 7;
            this.Favorite.Text = "My Favorite Songs";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(45, 78);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(121, 23);
            this.Singer.TabIndex = 6;
            this.Singer.Text = "Singer";
            this.Singer.UseVisualStyleBackColor = true;
            this.Singer.Click += new System.EventHandler(this.Singer_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(300, 147);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(205, 212);
            this.CategoryListBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.AppLogo;
            this.pictureBox1.Location = new System.Drawing.Point(45, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.Singer);
            this.Name = "Category";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button Singer;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}