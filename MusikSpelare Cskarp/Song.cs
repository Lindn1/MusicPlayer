using System;
using System.Drawing;
using System.IO;

namespace MusikSpelare_Cskarp
{
	internal class Song
	{
		private Uri path { get; }
		private TagLib.File file;
		private string artist;
		private string album;
		private string title;
		private string year;
		private string length;

		public Song(string path)
		{
			this.path = new Uri(path);
			file = TagLib.File.Create(this.path.OriginalString);
			artist = file.Tag.FirstAlbumArtist;
			album = file.Tag.Album;
			title = file.Tag.Title;
			year = file.Tag.Year.ToString();
			TimeSpan sl = file.Properties.Duration;
			length = sl.Subtract(new TimeSpan(sl.Milliseconds)).ToString();
		}

		public Uri GetPath() { return path; }
		public TagLib.File GetFile() { return file; }
		public string GetArtist() { return artist; }
		public string GetAlbum() { return album; }
		public string GetTitle() { return title; }
		public string GetYear() { return year; }
		public string GetLength() { return length; }
		public Image GetAlbumArt()
		{
			if(file.Tag.Pictures.Length > 0)
			{
				if(file.Tag.Pictures[0].Data.Data.Length > 0)
				{
					MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
					return Image.FromStream(ms); ;
				}
			}
			return Properties.Resources.NotLoaded; ;
		}

	}
}
