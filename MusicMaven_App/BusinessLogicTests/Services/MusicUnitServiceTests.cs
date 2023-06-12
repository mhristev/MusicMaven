using System;
using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using System.Collections.Generic;using Microsoft.VisualStudio.TestTools.UnitTesting;using Business_Logic.FakeRepositories;using Business_Logic.Interfaces.IServices;using Business_Logic.Enums;using Business_Logic.Models;namespace BusinessLogicTests.Services
{    [TestClass]    public class MusicUnitServiceTests
	{        private IMusicUnitService musicUnitService;        [TestInitialize]        public void Initialize()        {            var artistRepository = new FakeArtistRepository();            var albumRepository = new FakeAlbumRepository(artistRepository);            var songRepository = new FakeSongRepository(albumRepository);            var userRepository = new FakeUserRepository();            var reviewRepository = new FakeReviewRepository(userRepository, artistRepository);            var musicUnitRepository = new FakeMusicUnitRepository(albumRepository, artistRepository, songRepository, reviewRepository);            // Add fake data for albums, artists, and songs            var artists = new List<Artist>
            {
                new Artist { Id = "1", Name = "Artist Unit 1", AvrgRating = 3.2, Type = MUSIC_UNIT_TYPE.ARTIST },
                new Artist { Id = "2", Name = "Artist Unit 2", AvrgRating = 5.9, Type = MUSIC_UNIT_TYPE.ARTIST }
            };            artistRepository.Insert(artists[0]);            artistRepository.Insert(artists[1]);            var albums = new List<Album>
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, Artists = (new List<Artist> { artists[0] }).AsReadOnly(), ReleaseDate = DateTime.Now.AddDays(-4) },
                new Album { Id = "4", Name = "Album Unit 2", AvrgRating = 7.0, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-10) }
            };            albumRepository.Insert(albums[0]);            albumRepository.Insert(albums[1]);            var songs = new List<Song>
            {
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG, Album = albums[0] },
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG, Album = albums[0] }
            };            songRepository.Insert(songs[0]);            songRepository.Insert(songs[1]);            IArtistService artistService = new ArtistService(artistRepository);            IAlbumService albumService = new AlbumService(albumRepository);            ISongService songService = new SongService(songRepository);            musicUnitService = new MusicUnitService(albumService, songService, artistService, musicUnitRepository);        }        [TestMethod]        public void FindMusicUnitsByKeywordOrderedByHighestRated_ReturnsMusicUnits()        {            // Arrange            string keyword = "sOn";            List<MusicUnit> expectedMusicUnits = new List<MusicUnit>
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG }
            };            // Act            var actualMusicUnits = musicUnitService.FindMusicUnitsByKeywordOrderedByHighestRated(keyword);            // Assert            Assert.AreEqual(expectedMusicUnits.Count, actualMusicUnits.Count);            CollectionAssert.AreEqual(expectedMusicUnits, actualMusicUnits);        }        [TestMethod]        public void FindMusicUnitsByKeywordOrderedByHighestRated_ReturnsNoMusicUnits()        {            // Arrange            string keyword = "%/'";            List<MusicUnit> expectedMusicUnits = new List<MusicUnit>
            {};            // Act            var actualMusicUnits = musicUnitService.FindMusicUnitsByKeywordOrderedByHighestRated(keyword);            // Assert            Assert.AreEqual(expectedMusicUnits.Count, actualMusicUnits.Count);            CollectionAssert.AreEqual(expectedMusicUnits, actualMusicUnits);        }        [TestMethod]        public void GetMusicUnitWithId_ExistingId_ReturnsMusicUnit()        {            // Arrange            string existingId = "3";            MusicUnit expectedMusicUnit = new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM };            // Act            MusicUnit? actualMusicUnit = musicUnitService.GetMusicUnitWithId(existingId);            // Assert            Assert.IsNotNull(actualMusicUnit);            Assert.AreEqual(expectedMusicUnit, actualMusicUnit);            // Add more assertions for other properties as needed        }        [TestMethod]        public void GetMusicUnitWithId_NonexistentId_ReturnsNull()        {            // Arrange            string nonexistentId = "999";            // Act            MusicUnit? actualMusicUnit = musicUnitService.GetMusicUnitWithId(nonexistentId);            // Assert            Assert.IsNull(actualMusicUnit);        }        [TestMethod]        public void GetAlbumsForArtist_ExistingArtist_ReturnsAlbums()        {            // Arrange            Artist artist = new Artist { Id = "1", Name = "Artist Unit 1", AvrgRating = 3.2, Type = MUSIC_UNIT_TYPE.ARTIST };            List<Album> expectedAlbums = new List<Album>
            {
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, Artists = (new List<Artist> { artist }).AsReadOnly() }
            };            // Act            List<Album> actualAlbums = musicUnitService.GetAlbumsForArtist(artist);            // Assert            CollectionAssert.AreEqual(expectedAlbums, actualAlbums);        }        [TestMethod]        public void GetAlbumsForArtist_NonexistentArtist_ReturnsEmptyList()        {            // Arrange            Artist nonexistentArtist = new Artist { Id = "999", Name = "Nonexistent Artist" };            // Act            List<Album> actualAlbums = musicUnitService.GetAlbumsForArtist(nonexistentArtist);            // Assert            Assert.AreEqual(0, actualAlbums.Count);        }        [TestMethod]        public void GetSongsInAlbum_ExistingAlbum_ReturnsSongs()        {            // Arrange            Album album = new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM };            List<Song> expectedSongs = new List<Song>
            {
                new Song { Id = "5", Name = "Song Unit 1", AvrgRating = 6.1, Type = MUSIC_UNIT_TYPE.SONG, Album = album },
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG, Album = album }
            };            // Act            List<Song> actualSongs = musicUnitService.GetSongsInAlbum(album);            // Assert            CollectionAssert.AreEqual(expectedSongs, actualSongs);        }        [TestMethod]        public void GetSongsInAlbum_NonexistentAlbum_ReturnsEmptyList()        {            // Arrange            Album nonexistentAlbum = new Album { Id = "999", Name = "Nonexistent Album" };            // Act            List<Song> actualSongs = musicUnitService.GetSongsInAlbum(nonexistentAlbum);            // Assert            Assert.AreEqual(0, actualSongs.Count);        }        [TestMethod]
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
        }        [TestMethod]
        public void GetHighestRatedSongsForArtist_NonexistentArtist_ReturnsEmptyList()
        {
            // Arrange
            Artist nonexistentArtist = new Artist { Id = "999", Name = "Nonexistent Artist" };
            int songCount = 2;

            // Act
            List<Song> actualSongs = musicUnitService.GetHighestRatedSongsForArtist(nonexistentArtist, songCount);

            // Assert
            Assert.AreEqual(0, actualSongs.Count);
        }        [TestMethod]
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
        }        [TestMethod]        public void GetHighestRatedMusicUnits_ReturnsHighestRatedMusicUnits()        {            // Arrange            int unitCount = 2;            List<MusicUnit> expectedMusicUnits = new List<MusicUnit>
            {
                new Song { Id = "6", Name = "Song Unit 2", AvrgRating = 9.1, Type = MUSIC_UNIT_TYPE.SONG },
                new Album { Id = "3", Name = "Album Unit 1", AvrgRating = 8.1, Type = MUSIC_UNIT_TYPE.ALBUM, ReleaseDate = DateTime.Now.AddDays(-4) }
            };            // Act            List<MusicUnit> actualMusicUnits = musicUnitService.GetHighestRatedMusicUnits(unitCount);            // Assert            CollectionAssert.AreEqual(expectedMusicUnits, actualMusicUnits);        }        [TestMethod]
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
        }        [TestMethod]
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
        }        [TestMethod]
        public void GetLastReviewedMusicUnits_EmptyReviewList_ReturnsEmptyList()
        {
            // Arrange
            List<Review> reviews = new List<Review>();
            int unitCount = 3;

            // Act
            List<MusicUnit> actualMusicUnits = musicUnitService.GetLastReviewedMusicUnits(reviews, unitCount);

            // Assert
            Assert.AreEqual(0, actualMusicUnits.Count);
        }        [TestMethod]
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
        }    }
}

