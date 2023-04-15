using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces
{
	public interface ISongRepository : IRepository<Song>
	{
		List<Song> GetSongsInAlbumId(string id);		List<Song> GetHighestRatedSongsForArtistId(string id, int songCount);    }
}

