using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface IAlbumService
	{        List<Album> GetAlbumsForArtist(Artist artist);
        List<Album> GetNewReleasedAlbums(int albumCount);

        List<Album> GetAllAlbums();
        void CreateAlbum(Album album);        void UpdateAlbum(Album album);        void DeleteAlbum(Album album);    }
}

