namespace MusicPlayer
{
    partial class Searchs
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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchSongButton = new System.Windows.Forms.Button();
            this.SearchResultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(648, 51);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(348, 53);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(121, 21);
            this.Genre.TabIndex = 14;
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(491, 51);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(121, 23);
            this.Album.TabIndex = 13;
            this.Album.Text = "Album";
            this.Album.UseVisualStyleBackColor = true;
            this.Album.Click += new System.EventHandler(this.Album_Click);
            // 
            // Favorite
            // 
            this.Favorite.Location = new System.Drawing.Point(201, 51);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(121, 23);
            this.Favorite.TabIndex = 12;
            this.Favorite.Text = "My Favorite Songs";
            this.Favorite.UseVisualStyleBackColor = true;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Singer
            // 
            this.Singer.Location = new System.Drawing.Point(52, 51);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(121, 23);
            this.Singer.TabIndex = 11;
            this.Singer.Text = "Singer";
            this.Singer.UseVisualStyleBackColor = true;
            this.Singer.Click += new System.EventHandler(this.Singer_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(290, 133);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(141, 20);
            this.SearchTextBox.TabIndex = 16;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(187, 136);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(85, 13);
            this.SearchLabel.TabIndex = 17;
            this.SearchLabel.Text = "Keyword Search";
            // 
            // SearchSongButton
            // 
            this.SearchSongButton.Location = new System.Drawing.Point(482, 131);
            this.SearchSongButton.Name = "SearchSongButton";
            this.SearchSongButton.Size = new System.Drawing.Size(121, 23);
            this.SearchSongButton.TabIndex = 18;
            this.SearchSongButton.Text = "Search";
            this.SearchSongButton.UseVisualStyleBackColor = true;
            // 
            // SearchResultListView
            // 
            this.SearchResultListView.Location = new System.Drawing.Point(127, 185);
            this.SearchResultListView.Name = "SearchResultListView";
            this.SearchResultListView.Size = new System.Drawing.Size(567, 224);
            this.SearchResultListView.TabIndex = 19;
            this.SearchResultListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultListView.SelectedIndexChanged += new System.EventHandler(this.SearchResultListView_SelectedIndexChanged);
            // 
            // Searchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.SearchResultListView);
            this.Controls.Add(this.SearchSongButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.Singer);
            this.Name = "Searchs";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Button Album;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.Button Singer;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchSongButton;
        private System.Windows.Forms.ListView SearchResultListView;
    }
}