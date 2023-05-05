using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;using Business_Logic.Interfaces.IServices;namespace Business_Logic.Services
{
	public class ArtistService : IArtistService
	{        private IArtistRepository _artistRepository;        public ArtistService(IArtistRepository artistRepository)
		{
			_artistRepository = artistRepository;
		}        public void CreateArtist(Artist artist)        {            _artistRepository.Insert(artist);        }

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

