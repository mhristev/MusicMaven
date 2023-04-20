using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Services
{
	public class ArtistService
	{        private IArtistRepository _artistRepository;        public ArtistService(IArtistRepository artistRepository)
		{
			_artistRepository = artistRepository;
		}        public List<Artist> GetArtists() // add artist count
        {
            return _artistRepository.GetAll();
        }    }
}

