using System.Collections.Generic;
using System.Drawing;

namespace MusikSpelare_Cskarp.src
{
	public class Album
	{
		public Album(string albumName)
		{
			AlbumName = albumName;
		}
		public string AlbumName { get; }
		public Image AlbumImage { get; set; }
		public List<Song> Songs { get; }
	}
}
