using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface ISongService
	{        List<Song> GetSongsInAlbum(Album album);
        List<Song> GetHighestRatedSongsForArtist(Artist artist, int songCount);        void CreateSong(Song song);        void UpdateSong(Song song);        void DeleteSong(Song song);    }
}

