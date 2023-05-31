﻿using System;
using Business_Logic.Interfaces;
{
	public class ArtistService : IArtistService
	{
		{
			_artistRepository = artistRepository;
		}

        public void DeleteArtist(Artist artist)
        {
            _artistRepository.Delete(artist.Id);
        }

        public List<Artist> GetArtists() //TODO add artist count
        {
            return _artistRepository.GetAll();
        }

        public void UpdateArtist(Artist artist)
        {
            _artistRepository.Update(artist);
        }
    }
}
