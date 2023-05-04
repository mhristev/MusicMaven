using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;namespace Business_Logic.FakeRepositories
{
	public class FakeMusicUnitRepository : IMusicUnitRepository
	{
		private IAlbumRepository _albumRepository;
		private IArtistRepository _artistRepository;
		private ISongRepository _songRepository;

		public FakeMusicUnitRepository(IAlbumRepository albumRepo, IArtistRepository artistRepo, ISongRepository songRepo)
		{
			_albumRepository = albumRepo;
			_artistRepository = artistRepo;
			_songRepository = songRepo;
		}        public List<MusicUnit> GetHighestRatedUnits(int unitCount)        {            List<MusicUnit> allUnits = new List<MusicUnit>();            allUnits.AddRange(_albumRepository.GetAll());            allUnits.AddRange(_artistRepository.GetAll());            allUnits.AddRange(_songRepository.GetAll());            var topUnits = allUnits.OrderByDescending(u => u.AvrgRating)                                  .Take(unitCount)                                  .ToList();            return topUnits;        }        public MusicUnit? GetMusicUnitByid(string id)        {            MusicUnit? musicUnit = null;			Artist? artist = _artistRepository.GetById(id);			if (artist != null)			{				musicUnit = artist;			}			Album? album = _albumRepository.GetById(id);			if (album != null)			{				musicUnit = album;			}			Song? song = _songRepository.GetById(id);			if (song != null)			{				musicUnit = song;			}            return musicUnit;        }        public List<MusicUnit> GetMusicUnitsByKeywordInNameOrderedByHighestRated(string keyword)        {            List<MusicUnit> results = new List<MusicUnit>();            results.AddRange(_artistRepository.GetArtistsWithKeywordInName(keyword));            results.AddRange(_albumRepository.GetAlbumsWithKeywordInName(keyword));            results.AddRange(_songRepository.GetSongsWithKeywordInName(keyword));            return results.OrderByDescending(a => a.AvrgRating).ToList();        }    }
}

