using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface IArtistService
	{        List<Artist> GetArtists();
        void CreateArtist(Artist artist);        void UpdateArtist(Artist artist);        void DeleteArtist(Artist artist);    }
}

