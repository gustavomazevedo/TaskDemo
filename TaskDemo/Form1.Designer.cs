namespace TaskDemo
{
    partial class Form1
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
            this.imgCover = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchAsync = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.pbrMusic = new System.Windows.Forms.ProgressBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbxAlbums = new System.Windows.Forms.ListBox();
            this.lbxSongs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCover
            // 
            this.imgCover.Location = new System.Drawing.Point(583, 187);
            this.imgCover.Name = "imgCover";
            this.imgCover.Size = new System.Drawing.Size(183, 175);
            this.imgCover.TabIndex = 0;
            this.imgCover.TabStop = false;
            this.imgCover.Click += new System.EventHandler(this.imgCover_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(397, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchAsync
            // 
            this.btnSearchAsync.Location = new System.Drawing.Point(386, 68);
            this.btnSearchAsync.Name = "btnSearchAsync";
            this.btnSearchAsync.Size = new System.Drawing.Size(86, 23);
            this.btnSearchAsync.TabIndex = 3;
            this.btnSearchAsync.Text = "SearchAsync";
            this.btnSearchAsync.UseVisualStyleBackColor = true;
            this.btnSearchAsync.Click += new System.EventHandler(this.btnSearchAsync_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(12, 42);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Artist:";
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(11, 168);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(41, 13);
            this.lblAlbums.TabIndex = 6;
            this.lblAlbums.Text = "Albums";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(248, 168);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(37, 13);
            this.lblSongs.TabIndex = 8;
            this.lblSongs.Text = "Songs";
            // 
            // pbrMusic
            // 
            this.pbrMusic.Location = new System.Drawing.Point(517, 401);
            this.pbrMusic.Name = "pbrMusic";
            this.pbrMusic.Size = new System.Drawing.Size(315, 10);
            this.pbrMusic.TabIndex = 9;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(612, 440);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(44, 23);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "|>";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(685, 440);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(44, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lbxAlbums
            // 
            this.lbxAlbums.FormattingEnabled = true;
            this.lbxAlbums.Location = new System.Drawing.Point(13, 187);
            this.lbxAlbums.Name = "lbxAlbums";
            this.lbxAlbums.Size = new System.Drawing.Size(211, 303);
            this.lbxAlbums.TabIndex = 12;
            // 
            // lbxSongs
            // 
            this.lbxSongs.FormattingEnabled = true;
            this.lbxSongs.Location = new System.Drawing.Point(251, 187);
            this.lbxSongs.Name = "lbxSongs";
            this.lbxSongs.Size = new System.Drawing.Size(221, 303);
            this.lbxSongs.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 511);
            this.Controls.Add(this.lbxSongs);
            this.Controls.Add(this.lbxAlbums);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbrMusic);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchAsync);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.imgCover);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCover;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchAsync;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.ProgressBar pbrMusic;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbxAlbums;
        private System.Windows.Forms.ListBox lbxSongs;
    }
}

