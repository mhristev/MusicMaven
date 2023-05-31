﻿using System;
using Business_Logic.Interfaces.IServices;
{
	public class AlbumService : IAlbumService
	{

		public AlbumService(IAlbumRepository albumRepository)
		{
			_albumRepository = albumRepository;
		}

        public void DeleteAlbum(Album album)
        {
            _albumRepository.Delete(album.Id);
        }

        public List<Album> GetAlbumsForArtist(Artist artist)
        {
            return _albumRepository.GetAlbumsForArtistId(artist.Id);
        }

        public List<Album> GetAllAlbums()
        {
            return _albumRepository.GetAll();
        }

        public List<Album> GetNewReleasedAlbums(int albumCount)
        {
            return _albumRepository.GetNewReleasedAlbums(albumCount);
        }

        public void UpdateAlbum(Album album)
        {
            _albumRepository.Update(album);
        }
    }
}
