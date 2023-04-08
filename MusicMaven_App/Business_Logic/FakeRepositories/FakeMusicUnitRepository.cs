using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;namespace Business_Logic.FakeRepositories
{
	public class FakeMusicUnitRepository : IMusicUnitRepository
	{
		private IRepository<Album> _albumRepository;
		private IRepository<Artist> _artistRepository;
		private IRepository<Song> _songRepository;

		public FakeMusicUnitRepository(IRepository<Album> albumRepo, IRepository<Artist> artistRepo, IRepository<Song> songRepo)
		{
			_albumRepository = albumRepo;
			_artistRepository = artistRepo;
			_songRepository = songRepo;
		}        public List<MusicUnit> GetHighestRatedUnits(int unitCount)        {            List<MusicUnit> allUnits = new List<MusicUnit>();            allUnits.AddRange(_albumRepository.GetAll());            allUnits.AddRange(_artistRepository.GetAll());            allUnits.AddRange(_songRepository.GetAll());            var topUnits = allUnits.OrderByDescending(u => u.AvrgRating)                                  .Take(unitCount)                                  .ToList();            return topUnits;        }        public MusicUnit? GetMusicUnitByid(string id)        {            MusicUnit? musicUnit = null;			Artist? artist = _artistRepository.GetById(id);			if (artist != null)			{				musicUnit = artist;			}			Album? album = _albumRepository.GetById(id);			if (album != null)			{				musicUnit = album;			}			Song? song = _songRepository.GetById(id);			if (song != null)			{				musicUnit = song;			}            return musicUnit;        }    }
}

