﻿namespace MusikSpelare_Cskarp
{
    partial class MusicPlayer
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
			this.components = new System.ComponentModel.Container();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonPrevious = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.topRow = new System.Windows.Forms.Panel();
			this.topLabel = new System.Windows.Forms.Label();
			this.albumLabel = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.buttonNext = new System.Windows.Forms.Button();
			this.listSongBox = new System.Windows.Forms.ListBox();
			this.buttonLoadFolder = new System.Windows.Forms.Button();
			this.songLengthLabel = new System.Windows.Forms.Label();
			this.artistLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.yearLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.topRow.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPlay
			// 
			this.buttonPlay.Location = new System.Drawing.Point(236, 32);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(75, 23);
			this.buttonPlay.TabIndex = 0;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.UseVisualStyleBackColor = true;
			this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// buttonPause
			// 
			this.buttonPause.Location = new System.Drawing.Point(158, 32);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(75, 23);
			this.buttonPause.TabIndex = 1;
			this.buttonPause.Text = "Pause";
			this.buttonPause.UseVisualStyleBackColor = true;
			this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(80, 32);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// buttonPrevious
			// 
			this.buttonPrevious.Location = new System.Drawing.Point(314, 32);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
			this.buttonPrevious.TabIndex = 3;
			this.buttonPrevious.Text = "Previous";
			this.buttonPrevious.UseVisualStyleBackColor = true;
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::MusikSpelare_Cskarp.Properties.Resources.NotLoaded;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(241, 225);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(237, 237);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(128, 128);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// topRow
			// 
			this.topRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.topRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.topRow.Controls.Add(this.topLabel);
			this.topRow.Dock = System.Windows.Forms.DockStyle.Top;
			this.topRow.Location = new System.Drawing.Point(0, 0);
			this.topRow.Name = "topRow";
			this.topRow.Size = new System.Drawing.Size(762, 19);
			this.topRow.TabIndex = 5;
			// 
			// topLabel
			// 
			this.topLabel.AutoSize = true;
			this.topLabel.Location = new System.Drawing.Point(3, 0);
			this.topLabel.Name = "topLabel";
			this.topLabel.Size = new System.Drawing.Size(71, 13);
			this.topLabel.TabIndex = 0;
			this.topLabel.Text = "MusikSpelare";
			// 
			// albumLabel
			// 
			this.albumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.albumLabel.AutoSize = true;
			this.albumLabel.Location = new System.Drawing.Point(3, 13);
			this.albumLabel.Name = "albumLabel";
			this.albumLabel.Size = new System.Drawing.Size(42, 13);
			this.albumLabel.TabIndex = 4;
			this.albumLabel.Text = "Album: ";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(3, 3);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(729, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 6;
			// 
			// buttonNext
			// 
			this.buttonNext.Location = new System.Drawing.Point(392, 32);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(75, 23);
			this.buttonNext.TabIndex = 7;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			// 
			// listSongBox
			// 
			this.listSongBox.FormattingEnabled = true;
			this.listSongBox.Location = new System.Drawing.Point(15, 55);
			this.listSongBox.Name = "listSongBox";
			this.listSongBox.Size = new System.Drawing.Size(220, 407);
			this.listSongBox.TabIndex = 8;
			this.listSongBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListSongBox_DoubleClick);
			// 
			// buttonLoadFolder
			// 
			this.buttonLoadFolder.Location = new System.Drawing.Point(2, 32);
			this.buttonLoadFolder.Name = "buttonLoadFolder";
			this.buttonLoadFolder.Size = new System.Drawing.Size(75, 23);
			this.buttonLoadFolder.TabIndex = 9;
			this.buttonLoadFolder.Text = "Load Folder";
			this.buttonLoadFolder.UseVisualStyleBackColor = true;
			this.buttonLoadFolder.Click += new System.EventHandler(this.LoadMusicFolder);
			// 
			// songLengthLabel
			// 
			this.songLengthLabel.AutoSize = true;
			this.songLengthLabel.Location = new System.Drawing.Point(3, 52);
			this.songLengthLabel.Name = "songLengthLabel";
			this.songLengthLabel.Size = new System.Drawing.Size(74, 13);
			this.songLengthLabel.TabIndex = 10;
			this.songLengthLabel.Text = "Song Length: ";
			// 
			// artistLabel
			// 
			this.artistLabel.AutoSize = true;
			this.artistLabel.Location = new System.Drawing.Point(3, 0);
			this.artistLabel.Name = "artistLabel";
			this.artistLabel.Size = new System.Drawing.Size(36, 13);
			this.artistLabel.TabIndex = 11;
			this.artistLabel.Text = "Artist: ";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(3, 39);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(38, 13);
			this.titleLabel.TabIndex = 12;
			this.titleLabel.Text = "Song: ";
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Location = new System.Drawing.Point(3, 26);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(35, 13);
			this.yearLabel.TabIndex = 13;
			this.yearLabel.Text = "Year: ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonLoadFolder);
			this.panel1.Controls.Add(this.buttonPrevious);
			this.panel1.Controls.Add(this.buttonNext);
			this.panel1.Controls.Add(this.progressBar);
			this.panel1.Controls.Add(this.buttonStop);
			this.panel1.Controls.Add(this.buttonPause);
			this.panel1.Controls.Add(this.buttonPlay);
			this.panel1.Location = new System.Drawing.Point(15, 472);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(735, 58);
			this.panel1.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.artistLabel);
			this.panel2.Controls.Add(this.albumLabel);
			this.panel2.Controls.Add(this.songLengthLabel);
			this.panel2.Controls.Add(this.titleLabel);
			this.panel2.Controls.Add(this.yearLabel);
			this.panel2.Location = new System.Drawing.Point(241, 151);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 68);
			this.panel2.TabIndex = 15;
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(762, 542);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listSongBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.topRow);
			this.Name = "MusicPlayer";
			this.Text = "Musicplayer";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.topRow.ResumeLayout(false);
			this.topRow.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topRow;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ListBox listSongBox;
        private System.Windows.Forms.Button buttonLoadFolder;
        private System.Windows.Forms.Label songLengthLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

