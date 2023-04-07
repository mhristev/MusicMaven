using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces
{
	public interface IAlbumRepository
	{        List<Album> GetAlbumsForArtistId(string id);
        List<Album> GetNewReleasedAlbums(int albumCount);    }
}

