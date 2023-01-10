using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MusikSpelare_Cskarp
{
	public partial class MusicPlayer : Form
	{
		private MediaPlayer player = new MediaPlayer();
		//private List<Song> songList = new List<Song>();
		private List<string> songPaths = new List<string>();
		private Song currentSong;
		private int currentSongIndex;
		private Timer timer = new Timer();
		private bool isPlaying;

		public MusicPlayer()
		{
			InitializeComponent();
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

		private async void LoadMusicFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog fb = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer };

			if(fb.ShowDialog() == DialogResult.OK)
			{
				songPaths.Clear();
				foreach(string path in await Task.Run(() => GetMP3Files(fb.SelectedPath)))
				{
					try 
					{
						listSongBox.Items.Add(new Song(path).SongName);
						songPaths.Add(path);
					} 
					catch(System.ArgumentNullException) 
					{
						continue;
					}
					
				}
			}
		}

		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			PreviousSong(false);
		}

		private void buttonPrevious_DoubleClick(object sender, EventArgs e)
		{
			PreviousSong(true);
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			NextSong();
		}

		// Return all .mp3 files in a given directory (subdirectories included) as a List
		private List<string> GetMP3Files(string directory)
		{
			List<string> songFiles = new List<string>();

			// Get all files in the directory
			string[] files = Directory.GetFiles(directory, "*.mp3");
			foreach(string file in files)
			{
				songFiles.Add(file);
			}

			// Get all subdirectories
			string[] subdirectories = Directory.GetDirectories(directory);

			// Recursively search the subdirectories for .mp3 files
			foreach(string subdirectory in subdirectories)
			{
				songFiles.AddRange(GetMP3Files(subdirectory));
			}

			return songFiles;
		}

		private void ListSongBox_DoubleClick(object sender, MouseEventArgs e)
		{
			if(listSongBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
			{
				currentSongIndex = listSongBox.IndexFromPoint(e.Location);
				SetSong(songPaths[currentSongIndex], true);
			}
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
			player.Open(new Uri(currentSong.path));
			SetArtistName();
			SetAlbumName();
			SetSongName();
			SetSongLength();
			SetAlbumPicture();
			ConfigureProgressBar();
			if(playSongAfterSetting) { PlaySong(); }
		}
		private void SetArtistName() => artistLabel.Text = currentSong.ArtistName;
		private void SetAlbumName() => albumLabel.Text = currentSong.AlbumName;
		private void SetSongName() => titleLabel.Text = currentSong.SongName;
		private void SetSongLength() => songLengthLabel.Text = "Song Length: " + currentSong.SongLength;
		private void SetAlbumPicture() => pictureBox1.Image = currentSong.AlbumCover;
	}
}
