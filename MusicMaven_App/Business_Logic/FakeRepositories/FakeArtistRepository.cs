using System;
using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeArtistRepository: IArtistRepository
	{
        private readonly List<Artist> _artists = new List<Artist>();

        public FakeArtistRepository()
		{            _artists.Add(new Artist("1", "Tyler, The Creator", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5));            _artists.Add(new Artist("2", "Kendrick Lamar", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 5));            _artists.Add(new Artist("3", "Joeyy Bada$$", "images/artist.png", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 8));        }

        public void Delete(string id)
        {
            Artist? artistToRemove = _artists.FirstOrDefault(u => u.Id == id);
            if (artistToRemove != null)
            {
                _artists.Remove(artistToRemove);
            }
        }

        public List<Artist> GetAll()
        {
            return _artists;
        }

        public List<Artist> GetArtistsForAlbumId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Artist> GetArtistsWithKeywordInName(string keyword)        {            return _artists.Where(a => a.Name.ToLower().Contains(keyword.ToLower()))               .ToList();        }        public Artist? GetById(string id)
        {
            return _artists.FirstOrDefault(a => a.Id == id);
        }

        public void Insert(Artist entity)
        {
            _artists.Add(entity);
        }

        public void Update(Artist entity)
        {
            Artist? artist = _artists.FirstOrDefault(a => a.Id == entity.Id);            if (artist != null)            {                artist.Name = entity.Name;                artist.Image = entity.Image;                artist.ArtistType = entity.ArtistType;                artist.AvrgRating = entity.AvrgRating;            }
           
        }
    }
}

