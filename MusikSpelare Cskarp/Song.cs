using System.Drawing;
using System.IO;

namespace MusikSpelare_Cskarp
{
	internal class Song
	{
		private TagLib.File File { get; }
		public string Path { get; }
		public string SongName { get { return File.Tag.Title; } }
		public string ArtistName { get { return File.Tag.FirstAlbumArtist; } }
		public string AlbumName { get { return File.Tag.Album; } }
		public string AlbumYear { get { return File.Tag.Year.ToString(); } }
		public string SongLength { get { return File.Properties.Duration.Subtract(new System.TimeSpan(File.Properties.Duration.Seconds)).ToString(); } }
		public Image AlbumCover
		{
			get
			{
				if(File.Tag.Pictures.Length > 0)
				{
					using(MemoryStream ms = new MemoryStream(File.Tag.Pictures[0].Data.Data)) { return Image.FromStream(ms); }
				} else { return Properties.Resources.NotLoaded; }
			}
		}

		public Song(string Path)
		{
			this.Path = Path;
			this.File = TagLib.File.Create(Path);
		}
	}
}
