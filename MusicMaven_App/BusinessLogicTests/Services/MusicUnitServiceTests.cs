using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;using Business_Logic.Models;using Business_Logic.Models.Enums;using Business_Logic.Enums;namespace Business_Logic.Services.Tests
{
    

    [TestClass]
    public class MusicUnitServiceTests
    {
        private IAlbumRepository _albumRepository;        private ISongRepository _songRepository;        private IArtistRepository _artistRepository;        private IMusicUnitRepository _musicUnitRepository;        private MusicUnitService _service;

        [TestInitialize]        public void Initialize()        {            _artistRepository = new FakeArtistRepository();            _albumRepository = new FakeAlbumRepository(_artistRepository);            _songRepository = new FakeSongRepository(_albumRepository);                        _musicUnitRepository = new FakeMusicUnitRepository(_albumRepository, _artistRepository, _songRepository);            _service = new MusicUnitService(                _albumRepository,                _songRepository,                _artistRepository,                _musicUnitRepository);        }

        [TestMethod]
        public void GetMusicUnitWithNonExistentIdTest()
        {
            // Arrange
            string id = "randomId";

            // Act
            MusicUnit? result = _musicUnitRepository.GetMusicUnitByid(id);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetMusicUnitWithExistentIdTest()
        {
            // Arrange
            string id = Guid.NewGuid().ToString();            string expectedName = "testAlbum";            string expectedImage = "randomImage";            double expectedAvrgRating = 7.1;            MUSIC_UNIT_TYPE expectedType = MUSIC_UNIT_TYPE.ALBUM;            GENRE_TYPE expectedGenre = GENRE_TYPE.HIP_HOP;            Album expectedUnit = new Album(id, expectedName, expectedImage, expectedType,expectedGenre, new List<Artist>(), expectedAvrgRating, DateTime.Today);
            _albumRepository.Insert(expectedUnit);

            // Act
            MusicUnit? result = _musicUnitRepository.GetMusicUnitByid(id);

            // Assert
            Assert.IsNotNull(result);            Assert.AreEqual(expectedUnit, result);
        }
    }
}