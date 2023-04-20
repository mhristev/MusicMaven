using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Services
{
	public class AlbumService
	{        private IAlbumRepository _albumRepository;

		public AlbumService(IAlbumRepository albumRepository)
		{
			_albumRepository = albumRepository;
		}        public List<Album> GetAlbumsForArtist(Artist artist)
        {
            return _albumRepository.GetAlbumsForArtistId(artist.Id);
        }        public List<Album> GetNewReleasedAlbums(int albumCount)
        {
            return _albumRepository.GetNewReleasedAlbums(albumCount);
        }    }
}

