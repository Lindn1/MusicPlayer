using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusikSpelare_Cskarp
{
	public class MusicFiles
	{
		public string musicFolderSavePath =
			System.Environment.GetFolderPath
			(Environment.SpecialFolder.CommonApplicationData) + "\\musicfolders.txt";
		private string songsSavePath = System.Environment.GetFolderPath
					(Environment.SpecialFolder.CommonApplicationData) + "\\songs.txt";
		private string artistsAndSongsSavePath = System.Environment.GetFolderPath
					(Environment.SpecialFolder.CommonApplicationData) + "\\artistsandsongs.txt";
		private string albumsAndSongsSavePath = System.Environment.GetFolderPath
					(Environment.SpecialFolder.CommonApplicationData) + "\\albumsandsongs.txt";
		public List<string> songPaths = new List<string>();
		public List<Song> songs = new List<Song>();
		public Dictionary<string, string> artistsAndSongs = new Dictionary<string, string>();
		public Dictionary<string, string> albumsAndSongs = new Dictionary<string, string>();

		public async Task LoadMusicFolder()
		{
			FolderBrowserDialog fb = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer };
			if(fb.ShowDialog() == DialogResult.OK)
			{
				await GetMP3Files(fb.SelectedPath);
				await LoadArtistsAndSongs();
				await SaveToFile();
			}
		}

		private async Task GetMP3Files(string directory)
		{
			await Task.Run(async () =>
			{
				songPaths.AddRange(Directory.GetFiles(directory, "*.mp3"));
				foreach(string subdirectory in Directory.GetDirectories(directory))
				{
					await GetMP3Files(subdirectory);
				}
			});
		}

		private async Task LoadArtistsAndSongs()
		{
			await Task.Run(() =>
			{
				foreach(string songPath in songPaths)
				{
					Song song = new Song(songPath);
					songs.Add(song);
				}
			});
		}

		private async Task SaveToFile()
		{
			await Task.Run(() => File.WriteAllLines(musicFolderSavePath, songPaths));
			await Task.Run(() =>
			{
				using(MemoryStream ms = new MemoryStream())
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(ms, songs);
					byte[] bytes = ms.ToArray();
					File.WriteAllBytes(songsSavePath, bytes);
				}
			});
		}

		public async Task LoadMusicFolderAtStartUp()
		{
			if(File.Exists(musicFolderSavePath))
			{
				await Task.Run(() => songPaths.AddRange(File.ReadAllLines(musicFolderSavePath)));
			}
			if(File.Exists(songsSavePath))
			{
				await Task.Run(() =>
				{
					BinaryFormatter bf = new BinaryFormatter();
					Byte[] bytes;
					if(File.Exists(songsSavePath))
					{
						bytes = File.ReadAllBytes(songsSavePath);
						songs = (List<Song>)new BinaryFormatter().Deserialize(new MemoryStream(bytes));
					}
				});
			}
		}

		public List<string> GetSongPaths() { return songPaths; }
		public List<Song> GetSongs() { return songs; }
		public Dictionary<string, string> GetArtistsAndSongs() { return artistsAndSongs; }
		public Dictionary<string, string> GetAlbumsAndSongs() { return albumsAndSongs; }
	}
}
