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
		private List<Song> songList = new List<Song>();
		private List<string> songLink = new List<string>();
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

		//struct Songs
		//{
		//	private TagLib.File file;
		//	public Songs(string path)
		//	{
		//		file = TagLib.File.Create(path);
		//	}
		//	public string GetTitle() { return file.Name; }
		//}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			if(isPlaying)
			{
				player.Pause();
				isPlaying = false;
				return;
			}
			if(songList.Count == 0) { return; }
			if(currentSong == null)
			{
				SetSong(songList[0], true); 
				currentSongIndex = 0;
				return;
			}
			if(!isPlaying)
			{
				PlaySong();
				isPlaying = true;
			}
		}
		private void ButtonPause_Click(object sender, EventArgs e)
		{
			player.Pause();
			isPlaying = false;
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
				List<string> mp3Files = await Task.Run(() => GetMP3Files(fb.SelectedPath));
				songList.Clear();
				foreach(string file in mp3Files)
				{
					Song song = new Song(file);
					songList.Add(song);
					listSongBox.Items.Add(song.GetTitle());
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
			List<string> mp3Files = new List<string>();

			// Get all files in the directory
			string[] files = Directory.GetFiles(directory, "*.mp3");
			mp3Files.AddRange(files);

			// Get all subdirectories
			string[] subdirectories = Directory.GetDirectories(directory);

			// Recursively search the subdirectories for .mp3 files
			foreach(string subdirectory in subdirectories)
			{
				mp3Files.AddRange(GetMP3Files(subdirectory));
			}

			return mp3Files;
		}
		private void ListSongBox_DoubleClick(object sender, MouseEventArgs e)
		{
			if(listSongBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
			{
				currentSongIndex = listSongBox.IndexFromPoint(e.Location);
				SetSong(songList[currentSongIndex], true);
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
		private void PlaySong()
		{
			player.Play();
			isPlaying = true;
		}
		private void PreviousSong(bool doubleClick)
		{
			if(doubleClick)
			{
				if(currentSongIndex == 0) { return; }
				currentSongIndex--;
				Song song = songList[currentSongIndex];
				SetSong(song, isPlaying);
			} else { player.Position = TimeSpan.Zero; }
		}
		private void NextSong()
		{
			if(currentSongIndex < songList.Count - 1)
			{
				currentSongIndex++;
				Song song = songList[currentSongIndex];
				if(isPlaying) { SetSong(song, true); } else { SetSong(song, false); }
			}
		}
		// Sets labels to the songs details and configures progressbar length and position
		private void SetSong(Song song, bool playSongAfterSetting)
		{
			currentSong = song;
			player.Open(currentSong.GetPath());
			SetArtist();
			SetAlbum();
			SetTitle();
			SetSongLength();
			SetAlbumPicture();
			ConfigureProgressBar();
			if(playSongAfterSetting) { PlaySong(); }
		}
		private void SetArtist() => artistLabel.Text = currentSong.GetArtist();
		private void SetAlbum() => albumLabel.Text = currentSong.GetAlbum();
		private void SetTitle() => titleLabel.Text = currentSong.GetTitle();
		private void SetSongLength() => songLengthLabel.Text = "Song Length: " + currentSong.GetLength();
		private void SetAlbumPicture() { pictureBox1.Image = currentSong.GetAlbumArt(); pictureBox1.Refresh(); }
	}
}
