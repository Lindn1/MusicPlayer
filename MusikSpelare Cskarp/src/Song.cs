using System.Drawing;
using System.IO;

namespace MusikSpelare_Cskarp
{
	[System.Serializable]
	public class Song
	{
		public Song(string path)
		{
			this.path = path;
		}
		public string path;
		public string SongName
		{
			get
			{
				try { return TagLib.File.Create(path).Tag.Title; } 
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + path; } 
				catch(TagLib.UnsupportedFormatException) { return "UnsupportedFormatException: " + path; }
				catch(System.ArgumentNullException) { return "Null: " + path; }
			}
		}
		public string ArtistName
		{
			get
			{
				try { return TagLib.File.Create(path).Tag.FirstAlbumArtist; } 
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + path; }
				catch(System.ArgumentNullException) { return "Null: " + path; }
			}
		}
		public string AlbumName
		{
			get
			{
				try { return TagLib.File.Create(path).Tag.Album; } 
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + path; }
				catch(System.ArgumentNullException) { return "Null: " + path; }
			}
		}
		public string AlbumYear
		{
			get
			{
				try { return TagLib.File.Create(path).Tag.Year.ToString(); } 
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + path; }
			}
		}
		public string SongLength
		{
			get
			{
				try { return System.TimeSpan.FromSeconds((int)TagLib.File.Create(path).Properties.Duration.TotalSeconds).ToString(); } 
				catch(TagLib.CorruptFileException) { return "CorruptFileException: " + path; }
			}
		}
		public Image AlbumCover
		{
			get
			{
				TagLib.File file;
				try { file = TagLib.File.Create(path); } catch(TagLib.CorruptFileException) { return Properties.Resources.NotLoaded; }
				if(file.Tag.Pictures.Length > 0)
				{
					using(MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data))
					{
						Image img = Image.FromStream(ms);
						return img;
					}
				} else { return Properties.Resources.NotLoaded; }
			}
		}
	}
}
