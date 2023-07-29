﻿using System;
using Business_Logic.Interfaces;
{
	{
            {
                new Artist { Id = "1", Name = "Artist Unit 1", AvrgRating = 3.2, Type = MUSIC_UNIT_TYPE.ARTIST },
                new Artist { Id = "2", Name = "Artist Unit 2", AvrgRating = 5.9, Type = MUSIC_UNIT_TYPE.ARTIST }
            };
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, Artists = (new List<Artist> { artists[0] }).AsReadOnly(), ReleaseDate = DateTime.Now.AddDays(-4) },
                new Album { Id = "4", Name = "Album Unit 2", AvrgRating = 7.0, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-10) }
            };
            {
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG, Album = albums[0] },
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG, Album = albums[0] }
            };
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG }
            };
            {};
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, Artists = (new List<Artist> { artist }).AsReadOnly() }
            };
            {
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG, Album = album },
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG, Album = album }
            };
        public void GetHighestRatedSongsForArtist_ExistingArtist_ReturnsHighestRatedSongs()
        {
            // Arrange
            Artist artist = new Artist { Id = "1", Name = "Artist 1" };
            int songCount = 2;
            List<Song> expectedSongs = new List<Song>
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG }
            };

            // Act
            List<Song> actualSongs = musicUnitService.GetHighestRatedSongsForArtist(artist, songCount);

            // Assert
            CollectionAssert.AreEqual(expectedSongs, actualSongs);
        }
        public void GetHighestRatedSongsForArtist_NonexistentArtist_ReturnsEmptyList()
        {
            // Arrange
            Artist nonexistentArtist = new Artist { Id = "999", Name = "Nonexistent Artist" };
            int songCount = 2;

            // Act
            List<Song> actualSongs = musicUnitService.GetHighestRatedSongsForArtist(nonexistentArtist, songCount);

            // Assert
            Assert.AreEqual(0, actualSongs.Count);
        }
        public void GetNewReleasedAlbums_ReturnsNewReleasedAlbums()
        {
            // Arrange
            int albumCount = 2;
            List<Album> expectedAlbums = new List<Album>
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-4) },
                new Album { Id = "4", Name = "Album Unit 2", AvrgRating = 7.0, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-10) }
            };

            // Act
            List<Album> actualAlbums = musicUnitService.GetNewReleasedAlbums(albumCount);

            // Assert
            CollectionAssert.AreEqual(expectedAlbums, actualAlbums);
        }
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-4) }
            };
        public void GetHighestRatedSongsForArtist_ExistingArtist_InvalidSongCount_ReturnsAllSongs()
        {
            // Arrange
            Artist artist = new Artist { Id = "1", Name = "Artist 1" };
            int songCount = -1;
            List<Song> expectedSongs = new List<Song>
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG }
            };

            // Act
            List<Song> actualSongs = musicUnitService.GetHighestRatedSongsForArtist(artist, songCount);

            // Assert
            CollectionAssert.AreEqual(expectedSongs, actualSongs);
        }
        public void GetNewReleasedAlbums_InvalidAlbumCount_ReturnsAllAlbums()
        {
            // Arrange
            int albumCount = -1;
            List<Album> expectedAlbums = new List<Album>
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM },
                new Album { Id = "4", Name = "Album Unit 2", AvrgRating = 7.0, Type = MUSIC_UNIT_TYPE.ALBUM }
            };

            // Act
            List<Album> actualAlbums = musicUnitService.GetNewReleasedAlbums(albumCount);

            // Assert
            CollectionAssert.AreEqual(expectedAlbums, actualAlbums);
        }
        public void GetLastReviewedMusicUnits_EmptyReviewList_ReturnsEmptyList()
        {
            // Arrange
            List<Review> reviews = new List<Review>();
            int unitCount = 3;

            // Act
            List<MusicUnit> actualMusicUnits = musicUnitService.GetLastReviewedMusicUnits(reviews, unitCount);

            // Assert
            Assert.AreEqual(0, actualMusicUnits.Count);
        }
        public void GetHighestRatedMusicUnits_InvalidUnitCount_ReturnsAllMusicUnits()
        {
            // Arrange
            int unitCount = -1;
            List<MusicUnit> expectedMusicUnits = new List<MusicUnit>
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-4) },
                new Album { Id = "4", Name = "Album Unit 2", AvrgRating = 7.0, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-10) },
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Artist { Id = "2", Name = "Artist Unit 2", AvrgRating = 5.9, Type = MUSIC_UNIT_TYPE.ARTIST },
                new Artist { Id = "1", Name = "Artist Unit 1", AvrgRating = 3.2, Type = MUSIC_UNIT_TYPE.ARTIST },
            };

            // Act
            List<MusicUnit> actualMusicUnits = musicUnitService.GetHighestRatedMusicUnits(unitCount);

            // Assert
            CollectionAssert.AreEqual(expectedMusicUnits, actualMusicUnits);
        }
}
