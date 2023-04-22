using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;using Business_Logic.Interfaces.IServices;namespace Business_Logic.Services
{
	public class SongService : ISongService
	{        private ISongRepository _songRepository;        public SongService(ISongRepository songRepository)
		{
			_songRepository = songRepository;
		}        public List<Song> GetSongsInAlbum(Album album)
        {
            return _songRepository.GetSongsInAlbumId(album.Id);
        }        public List<Song> GetHighestRatedSongsForArtist(Artist artist, int songCount)
        {
            return _songRepository.GetHighestRatedSongsForArtistId(artist.Id, songCount);
        }    }
}

