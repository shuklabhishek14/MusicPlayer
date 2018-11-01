namespace MusicPlayer
{
    partial class MyFavoriteSongs
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
            this.FavoritesListBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AlbumBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SingersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FavoritesListBox
            // 
            this.FavoritesListBox.FormattingEnabled = true;
            this.FavoritesListBox.Location = new System.Drawing.Point(196, 148);
            this.FavoritesListBox.Name = "FavoritesListBox";
            this.FavoritesListBox.Size = new System.Drawing.Size(157, 212);
            this.FavoritesListBox.TabIndex = 11;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(643, 64);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(121, 23);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AlbumBtn
            // 
            this.AlbumBtn.Location = new System.Drawing.Point(486, 64);
            this.AlbumBtn.Name = "AlbumBtn";
            this.AlbumBtn.Size = new System.Drawing.Size(121, 23);
            this.AlbumBtn.TabIndex = 14;
            this.AlbumBtn.Text = "Album";
            this.AlbumBtn.UseVisualStyleBackColor = true;
            this.AlbumBtn.Click += new System.EventHandler(this.AlbumBtn_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(196, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "My Favorite Songs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SingersBtn
            // 
            this.SingersBtn.Location = new System.Drawing.Point(47, 64);
            this.SingersBtn.Name = "SingersBtn";
            this.SingersBtn.Size = new System.Drawing.Size(121, 23);
            this.SingersBtn.TabIndex = 12;
            this.SingersBtn.Text = "Singers";
            this.SingersBtn.UseVisualStyleBackColor = true;
            this.SingersBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // MyFavoriteSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AlbumBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SingersBtn);
            this.Controls.Add(this.FavoritesListBox);
            this.Enabled = false;
            this.Name = "MyFavoriteSongs";
            this.Text = "My Favorite Songs";
            this.Load += new System.EventHandler(this.MyFavoriteSongs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox FavoritesListBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AlbumBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SingersBtn;
    }
}