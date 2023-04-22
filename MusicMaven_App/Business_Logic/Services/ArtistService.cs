using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;using Business_Logic.Interfaces.IServices;namespace Business_Logic.Services
{
	public class ArtistService : IArtistService
	{        private IArtistRepository _artistRepository;        public ArtistService(IArtistRepository artistRepository)
		{
			_artistRepository = artistRepository;
		}        public List<Artist> GetArtists() // add artist count
        {
            return _artistRepository.GetAll();
        }    }
}

