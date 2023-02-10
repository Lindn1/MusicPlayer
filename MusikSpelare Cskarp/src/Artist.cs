using System.Collections.Generic;
using System.Drawing;

namespace MusikSpelare_Cskarp.src
{
	public class Artist
	{
		public Artist(string artistName)
		{
			ArtistName = artistName;
		}
		public string ArtistName { get; }
		public List<Album> Albums { get; }
		public Image ArtistImage { get; set; }
	}
}
