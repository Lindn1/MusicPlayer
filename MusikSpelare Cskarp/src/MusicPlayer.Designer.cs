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
			this.ButtonPlay = new System.Windows.Forms.Button();
			this.ButtonStop = new System.Windows.Forms.Button();
			this.AlbumPictureBox = new System.Windows.Forms.PictureBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ButtonNext = new System.Windows.Forms.Button();
			this.ListSongBox = new System.Windows.Forms.ListBox();
			this.ButtonLoadFolder = new System.Windows.Forms.Button();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.SongTextPanel = new System.Windows.Forms.Panel();
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.AlbumLabel = new System.Windows.Forms.Label();
			this.SongLengthLabel = new System.Windows.Forms.Label();
			this.SongLabel = new System.Windows.Forms.Label();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.ButtonPrevious = new MusikSpelare_Cskarp.DoubleClickButton();
			this.ArtistsButton = new System.Windows.Forms.Button();
			this.AllSongsButton = new System.Windows.Forms.Button();
			this.VolumeBar = new System.Windows.Forms.TrackBar();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).BeginInit();
			this.MainPanel.SuspendLayout();
			this.SongTextPanel.SuspendLayout();
			this.ImagePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonPlay
			// 
			this.ButtonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonPlay.Location = new System.Drawing.Point(359, 696);
			this.ButtonPlay.Name = "ButtonPlay";
			this.ButtonPlay.Size = new System.Drawing.Size(75, 23);
			this.ButtonPlay.TabIndex = 0;
			this.ButtonPlay.Text = "Play";
			this.ButtonPlay.UseVisualStyleBackColor = true;
			this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// ButtonStop
			// 
			this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonStop.Location = new System.Drawing.Point(521, 696);
			this.ButtonStop.Name = "ButtonStop";
			this.ButtonStop.Size = new System.Drawing.Size(75, 23);
			this.ButtonStop.TabIndex = 2;
			this.ButtonStop.Text = "Stop";
			this.ButtonStop.UseVisualStyleBackColor = true;
			this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
			// 
			// AlbumPictureBox
			// 
			this.AlbumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AlbumPictureBox.BackgroundImage = global::MusikSpelare_Cskarp.Properties.Resources.NotLoaded;
			this.AlbumPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AlbumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.AlbumPictureBox.Location = new System.Drawing.Point(6, 10);
			this.AlbumPictureBox.Name = "AlbumPictureBox";
			this.AlbumPictureBox.Size = new System.Drawing.Size(256, 256);
			this.AlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AlbumPictureBox.TabIndex = 1;
			this.AlbumPictureBox.TabStop = false;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(278, 669);
			this.ProgressBar.MarqueeAnimationSpeed = 200;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(718, 23);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar.TabIndex = 6;
			this.ProgressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
			// 
			// ButtonNext
			// 
			this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonNext.Location = new System.Drawing.Point(440, 696);
			this.ButtonNext.Name = "ButtonNext";
			this.ButtonNext.Size = new System.Drawing.Size(75, 23);
			this.ButtonNext.TabIndex = 7;
			this.ButtonNext.Text = ">>|";
			this.ButtonNext.UseVisualStyleBackColor = true;
			this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// ListSongBox
			// 
			this.ListSongBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ListSongBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ListSongBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListSongBox.FormattingEnabled = true;
			this.ListSongBox.ItemHeight = 15;
			this.ListSongBox.Location = new System.Drawing.Point(129, 15);
			this.ListSongBox.Name = "ListSongBox";
			this.ListSongBox.Size = new System.Drawing.Size(880, 589);
			this.ListSongBox.TabIndex = 8;
			this.ListSongBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListSongBox_DoubleClick);
			// 
			// ButtonLoadFolder
			// 
			this.ButtonLoadFolder.Location = new System.Drawing.Point(12, 114);
			this.ButtonLoadFolder.Name = "ButtonLoadFolder";
			this.ButtonLoadFolder.Size = new System.Drawing.Size(111, 44);
			this.ButtonLoadFolder.TabIndex = 9;
			this.ButtonLoadFolder.Text = "Load Folder";
			this.ButtonLoadFolder.UseVisualStyleBackColor = true;
			this.ButtonLoadFolder.Click += new System.EventHandler(this.buttonLoadFolder_ClickAsync);
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add(this.SongTextPanel);
			this.MainPanel.Controls.Add(this.ImagePanel);
			this.MainPanel.Controls.Add(this.ButtonLoadFolder);
			this.MainPanel.Controls.Add(this.ButtonPrevious);
			this.MainPanel.Controls.Add(this.ButtonNext);
			this.MainPanel.Controls.Add(this.ArtistsButton);
			this.MainPanel.Controls.Add(this.ProgressBar);
			this.MainPanel.Controls.Add(this.AllSongsButton);
			this.MainPanel.Controls.Add(this.ButtonStop);
			this.MainPanel.Controls.Add(this.VolumeBar);
			this.MainPanel.Controls.Add(this.ListSongBox);
			this.MainPanel.Controls.Add(this.ButtonPlay);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(1008, 729);
			this.MainPanel.TabIndex = 14;
			// 
			// SongTextPanel
			// 
			this.SongTextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SongTextPanel.Controls.Add(this.ArtistLabel);
			this.SongTextPanel.Controls.Add(this.AlbumLabel);
			this.SongTextPanel.Controls.Add(this.SongLengthLabel);
			this.SongTextPanel.Controls.Add(this.SongLabel);
			this.SongTextPanel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
			this.SongTextPanel.Location = new System.Drawing.Point(278, 604);
			this.SongTextPanel.Name = "SongTextPanel";
			this.SongTextPanel.Size = new System.Drawing.Size(256, 60);
			this.SongTextPanel.TabIndex = 15;
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.AutoSize = true;
			this.ArtistLabel.Location = new System.Drawing.Point(3, 17);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(61, 12);
			this.ArtistLabel.TabIndex = 11;
			this.ArtistLabel.Text = "Artist: ";
			// 
			// AlbumLabel
			// 
			this.AlbumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AlbumLabel.AutoSize = true;
			this.AlbumLabel.Location = new System.Drawing.Point(3, 31);
			this.AlbumLabel.Name = "AlbumLabel";
			this.AlbumLabel.Size = new System.Drawing.Size(54, 12);
			this.AlbumLabel.TabIndex = 4;
			this.AlbumLabel.Text = "Album: ";
			// 
			// SongLengthLabel
			// 
			this.SongLengthLabel.AutoSize = true;
			this.SongLengthLabel.Location = new System.Drawing.Point(3, 45);
			this.SongLengthLabel.Name = "SongLengthLabel";
			this.SongLengthLabel.Size = new System.Drawing.Size(96, 12);
			this.SongLengthLabel.TabIndex = 10;
			this.SongLengthLabel.Text = "Song Length: ";
			// 
			// SongLabel
			// 
			this.SongLabel.AutoSize = true;
			this.SongLabel.Location = new System.Drawing.Point(3, 3);
			this.SongLabel.Name = "SongLabel";
			this.SongLabel.Size = new System.Drawing.Size(47, 12);
			this.SongLabel.TabIndex = 12;
			this.SongLabel.Text = "Song: ";
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImagePanel.Controls.Add(this.AlbumPictureBox);
			this.ImagePanel.Location = new System.Drawing.Point(-1, 456);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(273, 274);
			this.ImagePanel.TabIndex = 21;
			// 
			// ButtonPrevious
			// 
			this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonPrevious.Location = new System.Drawing.Point(278, 696);
			this.ButtonPrevious.Name = "ButtonPrevious";
			this.ButtonPrevious.Size = new System.Drawing.Size(75, 23);
			this.ButtonPrevious.TabIndex = 3;
			this.ButtonPrevious.Text = "|<<";
			this.ButtonPrevious.UseVisualStyleBackColor = true;
			this.ButtonPrevious.DoubleClick += new System.EventHandler(this.ButtonPrevious_DoubleClick);
			this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
			// 
			// ArtistsButton
			// 
			this.ArtistsButton.Location = new System.Drawing.Point(12, 64);
			this.ArtistsButton.Name = "ArtistsButton";
			this.ArtistsButton.Size = new System.Drawing.Size(111, 44);
			this.ArtistsButton.TabIndex = 18;
			this.ArtistsButton.Text = "Artists";
			this.ArtistsButton.UseVisualStyleBackColor = true;
			this.ArtistsButton.Click += new System.EventHandler(this.artistsButton_Click);
			// 
			// AllSongsButton
			// 
			this.AllSongsButton.Location = new System.Drawing.Point(12, 14);
			this.AllSongsButton.Name = "AllSongsButton";
			this.AllSongsButton.Size = new System.Drawing.Size(111, 44);
			this.AllSongsButton.TabIndex = 17;
			this.AllSongsButton.Text = "All Songs";
			this.AllSongsButton.UseVisualStyleBackColor = true;
			// 
			// VolumeBar
			// 
			this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VolumeBar.AutoSize = false;
			this.VolumeBar.LargeChange = 10;
			this.VolumeBar.Location = new System.Drawing.Point(602, 696);
			this.VolumeBar.Maximum = 100;
			this.VolumeBar.Name = "VolumeBar";
			this.VolumeBar.Size = new System.Drawing.Size(394, 31);
			this.VolumeBar.TabIndex = 16;
			this.VolumeBar.TickFrequency = 10;
			this.VolumeBar.Value = 100;
			this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// MusicPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.MainPanel);
			this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F);
			this.MinimumSize = new System.Drawing.Size(700, 568);
			this.Name = "MusicPlayer";
			this.Text = "Musicplayer";
			((System.ComponentModel.ISupportInitialize)(this.AlbumPictureBox)).EndInit();
			this.MainPanel.ResumeLayout(false);
			this.SongTextPanel.ResumeLayout(false);
			this.SongTextPanel.PerformLayout();
			this.ImagePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.PictureBox AlbumPictureBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.ListBox ListSongBox;
        private System.Windows.Forms.Button ButtonLoadFolder;
		private System.Windows.Forms.Panel MainPanel;
		private DoubleClickButton ButtonPrevious;
		private System.Windows.Forms.TrackBar VolumeBar;
		private System.Windows.Forms.Button AllSongsButton;
		private System.Windows.Forms.Button ArtistsButton;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Panel SongTextPanel;
		private System.Windows.Forms.Label ArtistLabel;
		private System.Windows.Forms.Label AlbumLabel;
		private System.Windows.Forms.Label SongLengthLabel;
		private System.Windows.Forms.Label SongLabel;
		private System.Windows.Forms.Panel ImagePanel;
	}
}

