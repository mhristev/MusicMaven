﻿using System;
using Business_Logic.Interfaces;
{
	public class SongService : ISongService
	{
		{
			_songRepository = songRepository;
		}
        {
            return _songRepository.GetSongsInAlbumId(album.Id);
        }
        {
            return _songRepository.GetHighestRatedSongsForArtistId(artist.Id, songCount);
        }

        public void UpdateSong(Song song)
        {
            _songRepository.Update(song);
        }

        public void DeleteSong(Song song)
        {
            _songRepository.Delete(song.Id);
        }
    }
}
