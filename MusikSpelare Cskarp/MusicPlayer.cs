using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MusikSpelare_Cskarp
{
	public partial class MusicPlayer : Form
	{
		private string musicFolderSavePath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\musicfolders.txt";
		private MediaPlayer player = new MediaPlayer();
		private List<string> songPaths = new List<string>();
		private Song currentSong;
		private int currentSongIndex;
		private Timer timer = new Timer();
		private bool isPlaying;

		public MusicPlayer()
		{
			InitializeComponent();
			LoadMusicFolderAtStartUp();
			ConfigureTimer();
			SongEndedConfig();
		}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			if(isPlaying)
			{
				PauseSong();
				return;
			}
			if(songPaths.Count == 0) { return; }
			if(currentSong == null)
			{
				SetSong(songPaths[0], true);
				currentSongIndex = 0;
				return;
			}
			if(!isPlaying)
			{
				PlaySong();
				return;
			}
		}

		private void ButtonStop_Click(object sender, EventArgs e)
		{
			player.Stop();
			isPlaying = false;
		}

		private void ButtonPrevious_Click(object sender, EventArgs e)
		{
			PreviousSong(false);
		}

		private void ButtonPrevious_DoubleClick(object sender, EventArgs e)
		{
			PreviousSong(true);
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			NextSong();
		}

		private void LoadMusicFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog fb = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer };

			if(fb.ShowDialog() == DialogResult.OK)
			{
				songPaths.Clear();
				GetMP3Files(fb.SelectedPath);
				SaveToFile();
				AddToSongBox();
			}
		}

		private void AddToSongBox()
		{
			listSongBox.Items.AddRange(songPaths.ToArray());
		}

		private void GetMP3Files(string directory)
		{
			songPaths.AddRange(Directory.GetFiles(directory, "*.mp3"));
			string[] subdirectories = Directory.GetDirectories(directory);
			foreach(string subdirectory in subdirectories)
			{
				GetMP3Files(subdirectory);
			}
		}

		private async Task SaveToFile()
		{
			await Task.Run(() => File.WriteAllLines(musicFolderSavePath, songPaths));
		}

		private void LoadMusicFolderAtStartUp()
		{
			if(File.Exists(musicFolderSavePath))
			{
				songPaths.AddRange(File.ReadAllLines(musicFolderSavePath));
				AddToSongBox();
			}
		}

		private void ListSongBox_DoubleClick(object sender, MouseEventArgs e)
		{
			if(listSongBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
			{
				currentSongIndex = listSongBox.IndexFromPoint(e.Location);
				SetSong(songPaths[currentSongIndex], true);
			}
		}

		private void progressBar_MouseClick(object sender, MouseEventArgs e)
		{
			int clickPosition = (int)(((double)e.X / progressBar.Width) * player.NaturalDuration.TimeSpan.TotalMilliseconds);
			player.Position = TimeSpan.FromMilliseconds(clickPosition);
			progressBar.Value = clickPosition;
		}

		// Configures the timer used for the song progressbar.
		private void ConfigureTimer()
		{
			timer.Tick += (sender, args) => Timer_Tick(sender, args);
			timer.Interval = 500;
		}

		// Updates progressBar value with current position of mediaplayer.
		private void Timer_Tick(object sender, EventArgs e)
		{
			progressBar.Value = (int)player.Position.TotalMilliseconds;
		}

		// Configures song progressbar by setting the maximum length of the newly opened song as its maximum, starting the timer
		// then closing the timer and resetting the progressbar when media is ended (ended == stopped or unloaded, pause does not count as ended)
		private void ConfigureProgressBar()
		{
			player.MediaOpened += (sender, args) =>
			{
				progressBar.Maximum = (int)player.NaturalDuration.TimeSpan.TotalMilliseconds;
				timer.Start();
			};

			player.MediaEnded += (sender, args) =>
			{
				progressBar.Value = 0;
				timer.Stop();
			};
		}

		// Switch to next song after current song ends
		private void SongEndedConfig()
		{
			player.MediaEnded += (sender, args) => { if(isPlaying) { NextSong(); } };
		}

		private void PauseSong()
		{
			player.Pause();
			buttonPlay.Text = "Play";
			isPlaying = false;
		}
		private void PlaySong()
		{
			player.Play();
			buttonPlay.Text = "Pause";
			isPlaying = true;
		}

		private void PreviousSong(bool doubleClick)
		{
			if(doubleClick)
			{
				if(currentSongIndex == 0) { return; }
				currentSongIndex--;
				SetSong(songPaths[currentSongIndex], isPlaying);
			} else { player.Position = TimeSpan.Zero; }
		}

		private void NextSong()
		{
			if(currentSongIndex < songPaths.Count - 1)
			{
				currentSongIndex++;
				if(isPlaying) { SetSong(songPaths[currentSongIndex], true); } else { SetSong(songPaths[currentSongIndex], false); }
			}
		}

		// Sets labels to the songs details and configures progressbar length and position
		private void SetSong(string path, bool playSongAfterSetting)
		{
			currentSong = new Song(path);
			player.Open(new Uri(path));
			SetArtistName();
			SetSongName();
			SetAlbumName();
			SetSongYear();
			SetSongLength();
			SetAlbumPicture();
			ConfigureProgressBar();
			if(playSongAfterSetting) { PlaySong(); }
		}
		private void SetArtistName() => artistLabel.Text = "Artist: " + currentSong.ArtistName;
		private void SetSongName() => titleLabel.Text = "Song: " + currentSong.SongName;
		private void SetAlbumName() => albumLabel.Text = "Album: " + currentSong.AlbumName;
		private void SetSongYear() => yearLabel.Text = "Year: " + currentSong.AlbumYear;
		private void SetSongLength() => songLengthLabel.Text = "Song Length: " + currentSong.SongLength;
		private void SetAlbumPicture() => pictureBox1.Image = currentSong.AlbumCover;
	}
}
