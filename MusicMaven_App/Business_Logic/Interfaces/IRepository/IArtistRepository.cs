using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces
{
	public interface IArtistRepository : IRepository<Artist>
	{        List<Artist> GetArtistsWithKeywordInName(string keyword);
    }
}

