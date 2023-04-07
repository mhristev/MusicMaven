using System;
using Business_Logic.Enums;using Business_Logic.Factories;using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeSongRepository: IRepository<Song>
	{
        private readonly List<Song> _songs = new List<Song>();        public FakeSongRepository()
		{
            _songs.Add(new Song("7", "IGOR'S THEME", "images/song.png", MUSIC_UNIT_TYPE.SONG, 128, new Album("4", "IGOR", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 9, DateTime.Today), 8));
            _songs.Add(new Song("8", "EARFQUAKE", "images/song.png", MUSIC_UNIT_TYPE.SONG, 138, new Album("4", "IGOR", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 9, DateTime.Today), 9));            _songs.Add(new Song("9", "I THINK", "images/song.png", MUSIC_UNIT_TYPE.SONG, 133, new Album("4", "IGOR", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 9, DateTime.Today), 10));            _songs.Add(new Song("10", "EXACTLY WHAT YOU RUN FROM", "images/song.png", MUSIC_UNIT_TYPE.SONG, 90, new Album("4", "IGOR", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 9, DateTime.Today), 8));            _songs.Add(new Song("11", "Foreword", "images/song.png", MUSIC_UNIT_TYPE.SONG, 180, new Album("5", "Flower boy", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 8, DateTime.Today), 7));            _songs.Add(new Song("12", "Where This Flower Blooms", "images/song.png", MUSIC_UNIT_TYPE.SONG, 213, new Album("5", "Flower boy", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 12, DateTime.Today), 2));            _songs.Add(new Song("13", "Sometimes...", "images/song.png", MUSIC_UNIT_TYPE.SONG, 188, new Album("5", "Flower boy", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 12, DateTime.Today), 3));            _songs.Add(new Song("14", "See You Again", "images/song.png", MUSIC_UNIT_TYPE.SONG, 219, new Album("5", "Flower boy", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 12, DateTime.Today), 4));

            _songs.Add(new Song("15", "Sherane a.k.a Master Splinter's Daughter", "images/song.png", MUSIC_UNIT_TYPE.SONG, 294, new Album("6", "good kid, m.A.A.d city", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.HIP_HOP, new List<Artist>() { new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 4) }, 8, DateTime.Today), 9));
            _songs.Add(new Song("16", "Bitch, Don't Kill My Vibe", "images/song.png", MUSIC_UNIT_TYPE.SONG, 336, new Album("6", "good kid, m.A.A.d city", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.HIP_HOP, new List<Artist>() { new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 4) }, 8, DateTime.Today), 8));
            _songs.Add(new Song("17", "Backseat Freestyle", "images/song.png", MUSIC_UNIT_TYPE.SONG, 212, new Album("6", "good kid, m.A.A.d city", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.HIP_HOP, new List<Artist>() { new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 4) }, 8, DateTime.Today), 7));
            _songs.Add(new Song("18", "The Art of Peer Pressure", "images/song.png", MUSIC_UNIT_TYPE.SONG, 386, new Album("6", "good kid, m.A.A.d city", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.HIP_HOP, new List<Artist>() { new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 4) }, 8, DateTime.Today), 8));
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
        }

        public void Insert(Song entity)
        {
            _songs.Add(entity);
        }

        public void Update(Song entity)
        {
            Song? song = _songs.FirstOrDefault(s => s.Id == entity.Id);            if (song != null)            {                song.Name = entity.Name;                song.Image = entity.Image;                song.DurationInSeconds = entity.DurationInSeconds;                song.AvrgRating = entity.AvrgRating;                song.Album = entity.Album;            }
        }
    }
}

