namespace MusicPlayer
{
    partial class MainForm
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
            this.Singer = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Button();
            this.Album = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.GoToPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(56, 83);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(121, 23);
            this.Singer.TabIndex = 0;
            this.Singer.Text = "Singer";
            this.Singer.UseVisualStyleBackColor = true;
            this.Singer.Click += new System.EventHandler(this.Singer_Click);
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(205, 83);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(121, 23);
            this.Favorite.TabIndex = 1;
            this.Favorite.Text = "My Favorite Songs";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(495, 83);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(121, 23);
            this.Album.TabIndex = 3;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.Click += new System.EventHandler(this.Album_Click);
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(352, 85);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 21);
            this.Genre.TabIndex = 4;
            this.Genre.SelectedIndexChanged += new System.EventHandler(this.Genre_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(652, 83);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.ErrorImage = global::MusicPlayer.Properties.Resources.AppLogo;
            this.LogoPictureBox.Image = global::MusicPlayer.Properties.Resources.AppLogo;
            this.LogoPictureBox.ImageLocation = " ";
            this.LogoPictureBox.InitialImage = global::MusicPlayer.Properties.Resources.AppLogo;
            this.LogoPictureBox.Location = new System.Drawing.Point(205, 160);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(411, 215);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // GoToPlayer
            // 
            this.GoToPlayer.Location = new System.Drawing.Point(352, 401);
            this.GoToPlayer.Name = "GoToPlayer";
            this.GoToPlayer.Size = new System.Drawing.Size(121, 23);
            this.GoToPlayer.TabIndex = 7;
            this.GoToPlayer.Text = "Go To Player";
            this.GoToPlayer.UseVisualStyleBackColor = true;
            this.GoToPlayer.Click += new System.EventHandler(this.GoToPlayer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.GoToPlayer);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.Singer);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Singer;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button GoToPlayer;
    }
}