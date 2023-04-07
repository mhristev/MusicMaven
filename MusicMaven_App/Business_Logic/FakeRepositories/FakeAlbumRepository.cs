using System;
using Business_Logic.Enums;using Business_Logic.Factories;using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeAlbumRepository: IRepository<Album>
	{
        private readonly List<Album> _albums = new List<Album>();        public FakeAlbumRepository()
		{
            _albums.Add(new Album("4", "IGOR", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 9, DateTime.Today));            _albums.Add(new Album("5", "Flower boy", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 8, DateTime.Today));
            _albums.Add(new Album("6", "good kid, m.A.A.d city", "images/album.png", MUSIC_UNIT_TYPE.ALBUM, GENRE_TYPE.UNKNOWN, new List<Artist>() { new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5) }, 8, DateTime.Today));        }

        public void Delete(string id)
        {
            Album? albumToRemove = _albums.FirstOrDefault(u => u.Id == id);            if (albumToRemove != null)            {                _albums.Remove(albumToRemove);            }
        }

        public List<Album> GetAll()
        {
            return _albums;
        }

        public Album? GetById(string id)
        {
            return _albums.FirstOrDefault(a => a.Id == id);
        }

        public void Insert(Album entity)
        {
            _albums.Add(entity);
        }

        public void Update(Album entity)
        {
            Album? album = _albums.FirstOrDefault(a => a.Id == entity.Id);            if (album != null)            {                album.Name = entity.Name;                album.Image = entity.Image;                album.Genre = entity.Genre;                album.Artists = entity.Artists;                album.AvrgRating = entity.AvrgRating;                album.ReleaseDate = entity.ReleaseDate;            }
        }
    }
}

