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
		private readonly MediaPlayer player = new MediaPlayer();
		//private readonly List<string> songPaths = new List<string>();
		private Song currentSong;
		private int currentSongIndex;
		private readonly Timer timer = new Timer();
		private bool isPlaying;
		private MusicFiles musicFiles = new MusicFiles();

		public MusicPlayer()
		{
			InitializeComponent();
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
			LoadFolderOnStartup(); 
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
			ConfigureTimer();
			SongEndedConfig();
		}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			if(isPlaying) { PauseSong(); return; }
			if(musicFiles.songPaths.Count == 0) { return; }
			if(currentSong == null)
			{
				currentSongIndex = 0;
				SetSong(musicFiles.songPaths[currentSongIndex], true);
				return;
			}
			if(!isPlaying) { PlaySong(); return; }
		}

		private void ButtonStop_Click(object sender, EventArgs e) { StopSong(); }

		private void ButtonPrevious_Click(object sender, EventArgs e) { PreviousSong(false); }

		private void ButtonPrevious_DoubleClick(object sender, EventArgs e) { PreviousSong(true); }

		private void ButtonNext_Click(object sender, EventArgs e) { NextSong(); }

		private void AddToSongBox() { ListSongBox.Items.AddRange(musicFiles.songPaths.ToArray()); }

		private void ListSongBox_DoubleClick(object sender, MouseEventArgs e)
		{
			if(ListSongBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
			{
				currentSongIndex = ListSongBox.IndexFromPoint(e.Location);
				SetSong(musicFiles.songPaths[currentSongIndex], true);
			}
		}

		private void progressBar_MouseClick(object sender, MouseEventArgs e)
		{
			int clickPosition = (int)(((double)e.X / ProgressBar.Width) * player.NaturalDuration.TimeSpan.TotalMilliseconds);
			player.Position = TimeSpan.FromMilliseconds(clickPosition);
			ProgressBar.Value = clickPosition;
		}

		// Configures the timer used for the song progressbar.
		private void ConfigureTimer()
		{
			timer.Tick += (sender, args) => Timer_Tick(sender, args);
			timer.Interval = 500;
		}

		// Updates progressBar value with current position of mediaplayer.
		private void Timer_Tick(object sender, EventArgs e) { ProgressBar.Value = (int)player.Position.TotalMilliseconds; }

		// Configures song progressbar by setting the maximum length of the newly opened song as its maximum, starting the timer
		// then closing the timer and resetting the progressbar when media is ended (ended == stopped or unloaded, pause does not count as ended)
		private void ConfigureProgressBar()
		{
			player.MediaOpened += (sender, args) =>
			{
				ProgressBar.Maximum = (int)player.NaturalDuration.TimeSpan.TotalMilliseconds;
				timer.Start();
			};

			player.MediaEnded += (sender, args) =>
			{
				ProgressBar.Value = 0;
				timer.Stop();
			};
		}

		// Switch to next song after current song ends
		private void SongEndedConfig() { player.MediaEnded += (sender, args) => { if(isPlaying) { NextSong(); } }; }

		private void StopSong()
		{
			player.Stop();
			ButtonPlay.Text = "Play";
			isPlaying = false;
		}
		private void PauseSong()
		{
			player.Pause();
			ButtonPlay.Text = "Play";
			isPlaying = false;
		}
		private void PlaySong()
		{
			player.Play();
			ButtonPlay.Text = "Pause";
			isPlaying = true;
		}

		private void PreviousSong(bool doubleClick)
		{
			if(doubleClick)
			{
				if(currentSongIndex == 0) { return; }
				currentSongIndex--;
				SetSong(musicFiles.songPaths[currentSongIndex], isPlaying);
			} else { player.Position = TimeSpan.Zero; }
		}

		private void NextSong()
		{
			if(currentSongIndex < musicFiles.songPaths.Count - 1)
			{
				currentSongIndex++;
				if(isPlaying) { SetSong(musicFiles.songPaths[currentSongIndex], true); } else { SetSong(musicFiles.songPaths[currentSongIndex], false); }
			}
		}

		private void VolumeBar_Scroll(object sender, EventArgs e)
		{
			player.Volume = (double)VolumeBar.Value / 100;
		}

		// Sets labels to the songs details and configures progressbar length and position
		private void SetSong(string path, bool playSongAfterSetting)
		{
			currentSong = new Song(path);
			player.Open(new Uri(path));
			SetArtistName();
			SetSongName();
			SetAlbumName();
			SetSongLength();
			SetAlbumPicture();
			ConfigureProgressBar();
			if(playSongAfterSetting) { PlaySong(); }
		}
		private void SetArtistName() => ArtistLabel.Text = "Artist: " + currentSong.ArtistName;
		private void SetSongName() => SongLabel.Text = "Song: " + currentSong.SongName;
		private void SetAlbumName() => AlbumLabel.Text = "Album: " + currentSong.AlbumName;
		private void SetSongLength() => SongLengthLabel.Text = "Song Length: " + currentSong.SongLength;
		private void SetAlbumPicture() => AlbumPictureBox.Image = currentSong.AlbumCover;

		private void artistsButton_Click(object sender, EventArgs e)
		{

		}

		private async void buttonLoadFolder_ClickAsync(object sender, EventArgs e)
		{
			await musicFiles.LoadMusicFolder();
			AddToSongBox();
		}

		private async Task LoadFolderOnStartup()
		{
			await musicFiles.LoadMusicFolderAtStartUp();
			AddToSongBox();
		}
	}
}
