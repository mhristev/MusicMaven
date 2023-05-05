using System;
using Business_Logic.Interfaces.IServices;using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Services
{
	public class AlbumService : IAlbumService
	{        private IAlbumRepository _albumRepository;

		public AlbumService(IAlbumRepository albumRepository)
		{
			_albumRepository = albumRepository;
		}        public void CreateAlbum(Album album)        {            _albumRepository.Insert(album);        }

        public void DeleteAlbum(Album album)
        {
            _albumRepository.Delete(album.Id);
        }

        public List<Album> GetAlbumsForArtist(Artist artist)
        {
            return _albumRepository.GetAlbumsForArtistId(artist.Id);
        }        public List<Album> GetNewReleasedAlbums(int albumCount)
        {
            return _albumRepository.GetNewReleasedAlbums(albumCount);
        }

        public void UpdateAlbum(Album album)
        {
            _albumRepository.Update(album);
        }
    }
}

