using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
    public class FakeSongRepository : ISongRepository
    {
        private readonly List<Song> _songs = new List<Song>();        private IAlbumRepository _albumRepository;        public FakeSongRepository(IAlbumRepository albumRepository)
        {
            //_albumRepository = albumRepository;
            //Album? igor = _albumRepository.GetById("4");
            //if (igor != null)            //{            //    _songs.Add(new Song("7", "IGOR'S THEME", "images/song.png", MUSIC_UNIT_TYPE.SONG, 128, igor, 8));            //    _songs.Add(new Song("8", "EARFQUAKE", "images/song.png", MUSIC_UNIT_TYPE.SONG, 138, igor, 9));            //    _songs.Add(new Song("9", "I THINK", "images/song.png", MUSIC_UNIT_TYPE.SONG, 133, igor, 10));            //    _songs.Add(new Song("10", "EXACTLY WHAT YOU RUN FROM", "images/song.png", MUSIC_UNIT_TYPE.SONG, 90, igor, 8));            //}            //Album? flowerBoy = _albumRepository.GetById("5");
            //if (flowerBoy != null)            //{            //    _songs.Add(new Song("11", "Foreword", "images/song.png", MUSIC_UNIT_TYPE.SONG, 180, flowerBoy, 7));            //    _songs.Add(new Song("12", "Where This Flower Blooms", "images/song.png", MUSIC_UNIT_TYPE.SONG, 213, flowerBoy, 2));            //    _songs.Add(new Song("13", "Sometimes...", "images/song.png", MUSIC_UNIT_TYPE.SONG, 188, flowerBoy, 3));            //    _songs.Add(new Song("14", "See You Again", "images/song.png", MUSIC_UNIT_TYPE.SONG, 219, flowerBoy, 4));
            //}
            //Album? goodKidMadCity = _albumRepository.GetById("6");
            //if (goodKidMadCity != null)            //{            //    _songs.Add(new Song("15", "Sherane a.k.a Master Splinter's Daughter", "images/song.png", MUSIC_UNIT_TYPE.SONG, 294, goodKidMadCity, 9));            //    _songs.Add(new Song("16", "Bitch, Don't Kill My Vibe", "images/song.png", MUSIC_UNIT_TYPE.SONG, 336, goodKidMadCity, 8));            //    _songs.Add(new Song("17", "Backseat Freestyle", "images/song.png", MUSIC_UNIT_TYPE.SONG, 212, goodKidMadCity, 7));            //    _songs.Add(new Song("18", "The Art of Peer Pressure", "images/song.png", MUSIC_UNIT_TYPE.SONG, 386, goodKidMadCity, 8));            //}
        }

        public void Delete(string id)
        {
            Song? songToRemove = _songs.FirstOrDefault(u => u.Id == id);            if (songToRemove != null)            {                _songs.Remove(songToRemove);            }
        }

        public List<Song> GetAll()
        {
            return _songs;
        }

        public Song? GetById(string id)
        {
            return _songs.FirstOrDefault(s => s.Id == id);
        }        public void Insert(Song entity)
        {
            _songs.Add(entity);
        }

        public void Update(Song entity)
        {
            Song? song = _songs.FirstOrDefault(s => s.Id == entity.Id);            if (song != null)            {                song.Name = entity.Name;                song.Image = entity.Image;                song.DurationInSeconds = entity.DurationInSeconds;                song.AvrgRating = entity.AvrgRating;                song.Album = entity.Album;            }
        }

        public List<Song> GetHighestRatedSongsForArtistId(string id, int songCount)        {            List<Song> result = new List<Song>();            if (songCount > -1)            {                result = _songs                    .Where(s => s.Album.Artists.Any(a => a.Id == id))                    .OrderByDescending(s => s.AvrgRating).Take(songCount)                    .ToList();            }            else            {                result = _songs                    .Where(s => s.Album.Artists.Any(a => a.Id == id))                    .OrderByDescending(s => s.AvrgRating)                    .ToList();            }            return result;        }        public List<Song> GetSongsInAlbumId(string id)        {            List<Song> result = _songs                .Where(s => s.Album.Id == id)                .ToList();            return result;        }        public List<Song> GetSongsWithKeywordInName(string keyword)        {            return _songs.Where(a => a.Name.ToLower().Contains(keyword.ToLower()))                .ToList();        }    }
}

