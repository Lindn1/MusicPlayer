using System.Drawing;
using System.IO;

namespace MusikSpelare_Cskarp
{
	[System.Serializable]
	public class Song
	{
		public Song(string path)
		{
			Path = path;
			try { SongName = TagLib.File.Create(path).Tag.Title; }
			catch(TagLib.CorruptFileException) { SongName = "CorruptFileException: " + path; }
			catch(TagLib.UnsupportedFormatException) { SongName = "UnsupportedFormatException: " + path; }
			catch(System.ArgumentNullException) { SongName = "Null: " + path; };
		}
		public string Path { get; }
		public string SongName { get; }
		public string ArtistName
		{
			get
			{
				try { return TagLib.File.Create(Path).Tag.FirstAlbumArtist; }
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + Path; }
				catch(System.ArgumentNullException) { return "Null: " + Path; }
			}
		}
		public string AlbumName
		{
			get
			{
				try { return TagLib.File.Create(Path).Tag.Album; }
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + Path; }
				catch(System.ArgumentNullException) { return "Null: " + Path; }
			}
		}
		public string AlbumYear
		{
			get
			{
				try { return TagLib.File.Create(Path).Tag.Year.ToString(); }
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + Path; }
			}
		}
		public string SongLength
		{
			get
			{
				try
				{
					return System.TimeSpan.FromSeconds((int)TagLib.File.Create(Path)
					.Properties.Duration.TotalSeconds).ToString();
				}
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + Path; }
			}
		}
		public Image AlbumCover
		{
			get
			{
				TagLib.File file;
				try { file = TagLib.File.Create(Path); }
				catch(TagLib.CorruptFileException) { return Properties.Resources.NotLoaded; }
				if(file.Tag.Pictures.Length > 0)
				{
					using(MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data))
					{
						Image img = Image.FromStream(ms);
						return img;
					}
				}
				else { return Properties.Resources.NotLoaded; }
			}
		}
	}
}
