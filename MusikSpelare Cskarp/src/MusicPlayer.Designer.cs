namespace MusikSpelare_Cskarp
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
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.albumPictureBox = new System.Windows.Forms.PictureBox();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.ButtonNext = new System.Windows.Forms.Button();
			this.listSongBox = new System.Windows.Forms.ListBox();
			this.buttonLoadFolder = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.VolumeBar = new System.Windows.Forms.TrackBar();
			this.allSongsButton = new System.Windows.Forms.Button();
			this.artistsButton = new System.Windows.Forms.Button();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.yearLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.songLengthLabel = new System.Windows.Forms.Label();
			this.albumLabel = new System.Windows.Forms.Label();
			this.artistLabel = new System.Windows.Forms.Label();
			this.songTextPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonPrevious = new MusikSpelare_Cskarp.DoubleClickButton();
			((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.songTextPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPlay
			// 
			this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPlay.Location = new System.Drawing.Point(354, 696);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(75, 23);
			this.buttonPlay.TabIndex = 0;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.UseVisualStyleBackColor = true;
			this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonStop.Location = new System.Drawing.Point(516, 696);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// albumPictureBox
			// 
			this.albumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.albumPictureBox.BackgroundImage = global::MusikSpelare_Cskarp.Properties.Resources.NotLoaded;
			this.albumPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.albumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.albumPictureBox.Location = new System.Drawing.Point(3, 77);
			this.albumPictureBox.Name = "albumPictureBox";
			this.albumPictureBox.Size = new System.Drawing.Size(256, 256);
			this.albumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.albumPictureBox.TabIndex = 1;
			this.albumPictureBox.TabStop = false;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(273, 667);
			this.progressBar.MarqueeAnimationSpeed = 200;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(728, 23);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 6;
			this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
			// 
			// ButtonNext
			// 
			this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonNext.Location = new System.Drawing.Point(435, 696);
			this.ButtonNext.Name = "ButtonNext";
			this.ButtonNext.Size = new System.Drawing.Size(75, 23);
			this.ButtonNext.TabIndex = 7;
			this.ButtonNext.Text = ">>|";
			this.ButtonNext.UseVisualStyleBackColor = true;
			this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// listSongBox
			// 
			this.listSongBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listSongBox.FormattingEnabled = true;
			this.listSongBox.Location = new System.Drawing.Point(129, 14);
			this.listSongBox.Name = "listSongBox";
			this.listSongBox.Size = new System.Drawing.Size(876, 628);
			this.listSongBox.TabIndex = 8;
			this.listSongBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListSongBox_DoubleClick);
			// 
			// buttonLoadFolder
			// 
			this.buttonLoadFolder.Location = new System.Drawing.Point(12, 114);
			this.buttonLoadFolder.Name = "buttonLoadFolder";
			this.buttonLoadFolder.Size = new System.Drawing.Size(111, 44);
			this.buttonLoadFolder.TabIndex = 9;
			this.buttonLoadFolder.Text = "Load Folder";
			this.buttonLoadFolder.UseVisualStyleBackColor = true;
			this.buttonLoadFolder.Click += new System.EventHandler(this.buttonLoadFolder_ClickAsync);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.buttonLoadFolder);
			this.panel1.Controls.Add(this.buttonPrevious);
			this.panel1.Controls.Add(this.ButtonNext);
			this.panel1.Controls.Add(this.artistsButton);
			this.panel1.Controls.Add(this.progressBar);
			this.panel1.Controls.Add(this.allSongsButton);
			this.panel1.Controls.Add(this.buttonStop);
			this.panel1.Controls.Add(this.VolumeBar);
			this.panel1.Controls.Add(this.listSongBox);
			this.panel1.Controls.Add(this.buttonPlay);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 729);
			this.panel1.TabIndex = 14;
			// 
			// VolumeBar
			// 
			this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VolumeBar.AutoSize = false;
			this.VolumeBar.LargeChange = 10;
			this.VolumeBar.Location = new System.Drawing.Point(597, 696);
			this.VolumeBar.Maximum = 100;
			this.VolumeBar.Name = "VolumeBar";
			this.VolumeBar.Size = new System.Drawing.Size(404, 31);
			this.VolumeBar.TabIndex = 16;
			this.VolumeBar.TickFrequency = 10;
			this.VolumeBar.Value = 100;
			this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
			// 
			// allSongsButton
			// 
			this.allSongsButton.Location = new System.Drawing.Point(12, 14);
			this.allSongsButton.Name = "allSongsButton";
			this.allSongsButton.Size = new System.Drawing.Size(111, 44);
			this.allSongsButton.TabIndex = 17;
			this.allSongsButton.Text = "All Songs";
			this.allSongsButton.UseVisualStyleBackColor = true;
			// 
			// artistsButton
			// 
			this.artistsButton.Location = new System.Drawing.Point(12, 64);
			this.artistsButton.Name = "artistsButton";
			this.artistsButton.Size = new System.Drawing.Size(111, 44);
			this.artistsButton.TabIndex = 18;
			this.artistsButton.Text = "Artists";
			this.artistsButton.UseVisualStyleBackColor = true;
			this.artistsButton.Click += new System.EventHandler(this.artistsButton_Click);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Location = new System.Drawing.Point(3, 39);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(35, 13);
			this.yearLabel.TabIndex = 13;
			this.yearLabel.Text = "Year: ";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(3, 13);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(38, 13);
			this.titleLabel.TabIndex = 12;
			this.titleLabel.Text = "Song: ";
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
			// albumLabel
			// 
			this.albumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.albumLabel.AutoSize = true;
			this.albumLabel.Location = new System.Drawing.Point(3, 26);
			this.albumLabel.Name = "albumLabel";
			this.albumLabel.Size = new System.Drawing.Size(42, 13);
			this.albumLabel.TabIndex = 4;
			this.albumLabel.Text = "Album: ";
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
			// songTextPanel
			// 
			this.songTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.songTextPanel.Controls.Add(this.artistLabel);
			this.songTextPanel.Controls.Add(this.albumLabel);
			this.songTextPanel.Controls.Add(this.songLengthLabel);
			this.songTextPanel.Controls.Add(this.titleLabel);
			this.songTextPanel.Controls.Add(this.yearLabel);
			this.songTextPanel.Location = new System.Drawing.Point(3, 3);
			this.songTextPanel.Name = "songTextPanel";
			this.songTextPanel.Size = new System.Drawing.Size(256, 68);
			this.songTextPanel.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.songTextPanel);
			this.panel2.Controls.Add(this.albumPictureBox);
			this.panel2.Location = new System.Drawing.Point(4, 383);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 336);
			this.panel2.TabIndex = 21;
			// 
			// buttonPrevious
			// 
			this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPrevious.Location = new System.Drawing.Point(273, 696);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
			this.buttonPrevious.TabIndex = 3;
			this.buttonPrevious.Text = "|<<";
			this.buttonPrevious.UseVisualStyleBackColor = true;
			this.buttonPrevious.DoubleClick += new System.EventHandler(this.ButtonPrevious_DoubleClick);
			this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(700, 568);
			this.Name = "MusicPlayer";
			this.Text = "Musicplayer";
			((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.songTextPanel.ResumeLayout(false);
			this.songTextPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.PictureBox albumPictureBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.ListBox listSongBox;
        private System.Windows.Forms.Button buttonLoadFolder;
		private System.Windows.Forms.Panel panel1;
		private DoubleClickButton buttonPrevious;
		private System.Windows.Forms.TrackBar VolumeBar;
		private System.Windows.Forms.Button allSongsButton;
		private System.Windows.Forms.Button artistsButton;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Panel songTextPanel;
		private System.Windows.Forms.Label artistLabel;
		private System.Windows.Forms.Label albumLabel;
		private System.Windows.Forms.Label songLengthLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Panel panel2;
	}
}

