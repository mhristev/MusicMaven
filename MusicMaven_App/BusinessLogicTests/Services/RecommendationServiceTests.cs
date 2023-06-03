using System;
using System.Collections.Generic;using System.Linq;using System.Reflection;using System.Threading.Tasks;using Business_Logic.FakeRepositories;using Business_Logic.Interfaces;using Business_Logic.Interfaces.IServices;using Business_Logic.Models;using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using Microsoft.VisualStudio.TestTools.UnitTesting;namespace BusinessLogicTests.Services
{    [TestClass]    public class RecommendationServiceTests    {        private IUserRepository userRepository;        private IMusicUnitRepository musicUnitRepository;        private IReviewRepository reviewRepository;        private IArtistRepository artistRepository;        private IAlbumRepository albumRepository;        private ISongRepository songRepository;        private RecommendationService recommendationService;        [TestInitialize]        public void Initialize()        {            artistRepository = new FakeArtistRepository();            albumRepository = new FakeAlbumRepository(artistRepository);            songRepository = new FakeSongRepository(albumRepository);            userRepository = new FakeUserRepository();            reviewRepository = new FakeReviewRepository(userRepository, artistRepository);            musicUnitRepository = new FakeMusicUnitRepository(albumRepository, artistRepository, songRepository, reviewRepository);                    }        [TestMethod]        public async Task GetRecommendationsForUser_ReturnsCorrectRecommendations()        {            // Arrange            var user4 = new User { Id = "user4" };            userRepository.Insert(user4);            var user1 = new User { Id = "user1", Email = "asd@mail.com", Username = "1" };            userRepository.Insert(user1);            var user2 = new User { Id = "user2", Email = "asd1@mail.com", Username = "2" };            userRepository.Insert(user2);            var user3 = new User { Id = "user3", Email = "asd33@mail.com", Username = "3" };            userRepository.Insert(user3);            var user = user4;            var numRecommendations = 1;            var musicUnits = new List<MusicUnit>
            {
                new Album { Id = "album1", AvrgRating = 4.2 },
                new Artist { Id = "artist1", AvrgRating = 4.8 },
                new Song { Id = "song1", AvrgRating = 3.5 },
                new Album { Id = "album2", AvrgRating = 4.6 },
                new Song { Id = "song2", AvrgRating = 4.0 }
            };            foreach (var unit in musicUnits)            {                if (unit is Album album)                {                    albumRepository.Insert(album);                }                else if (unit is Artist artist)                {                    artistRepository.Insert(artist);                }                else if (unit is Song song)                {                    songRepository.Insert(song);                }            }            var reviews = new List<Review>
    {
        new Review { Creator = user1, MusicUnit = musicUnits[0], Rating = 9.0 },
        new Review { Creator = user2, MusicUnit = musicUnits[0], Rating = 2.0 },
        new Review { Creator = user3, MusicUnit = musicUnits[0], Rating = 5.0 },

        new Review { Creator = user1, MusicUnit = musicUnits[1], Rating = 6.0 },
        new Review { Creator = user2, MusicUnit = musicUnits[1], Rating = 10.0 },
        new Review { Creator = user3, MusicUnit = musicUnits[1], Rating = 9.0 },
        new Review { Creator = user4, MusicUnit = musicUnits[1], Rating = 10.0 },

        new Review { Creator = user1, MusicUnit = musicUnits[2], Rating = 8.0 },
        new Review { Creator = user2, MusicUnit = musicUnits[2], Rating = 6.0 },
        new Review { Creator = user4, MusicUnit = musicUnits[2], Rating = 7.0 },

        new Review { Creator = user1, MusicUnit = musicUnits[3], Rating = 4.0 },
        new Review { Creator = user3, MusicUnit = musicUnits[3], Rating = 10.0 },
        new Review { Creator = user4, MusicUnit = musicUnits[3], Rating = 8.0 },

        new Review { Creator = user2, MusicUnit = musicUnits[4], Rating = 8.0 },
        new Review { Creator = user3, MusicUnit = musicUnits[4], Rating = 7.0 },

    };            foreach (var review in reviews)            {                reviewRepository.Insert(review);            }            var expectedRecommendations = new List<MusicUnit>
            {
                musicUnits[4]
            };            var recommendationService = new RecommendationService(userRepository, musicUnitRepository, reviewRepository);            await recommendationService.Setup();            // Act             var recommendations = await recommendationService.GetRecommendationsForUser(user, numRecommendations);            // Assert            CollectionAssert.AreEqual(expectedRecommendations, recommendations);        }


        [TestMethod]        public async Task ItemBasedCollaborativeFiltering_ReturnsCorrectRecommendations()        {            // Create users            var ivan = new User { Id = "Ivan", Email = "ivan@mail.com", Username = "ivan" };            var petar = new User { Id = "Petar", Email = "petar@mail.com", Username = "petar" };            var maria = new User { Id = "Maria", Email = "maria@mail.com", Username = "maria" };            var martin = new User { Id = "Martin", Email = "martin@mail.com", Username = "martin" };            userRepository.Insert(ivan);            userRepository.Insert(petar);            userRepository.Insert(maria);            userRepository.Insert(martin);            // Create music units            var beyonce = new Artist { Id = "Beyonce" };            var jid = new Artist { Id = "JID" };            var jayZ = new Artist { Id = "Jay-Z" };            var kendrick = new Artist { Id = "Kendrick" };            var amine = new Artist { Id = "Amine" };            var macMiller = new Artist { Id = "Mac Miller" };            var sza = new Artist { Id = "SZA" };            var kaliUchis = new Artist { Id = "Kali Uchis" };            artistRepository.Insert(beyonce);            artistRepository.Insert(jid);            artistRepository.Insert(jayZ);            artistRepository.Insert(kendrick);            artistRepository.Insert(amine);            artistRepository.Insert(macMiller);            artistRepository.Insert(sza);            artistRepository.Insert(kaliUchis);            // Set up ratings            var reviews = new List<Review>
            {
                new Review { Creator = ivan, MusicUnit = beyonce, Rating = 9.0 },
                new Review { Creator = petar, MusicUnit = beyonce, Rating = 2.0 },
                new Review { Creator = maria, MusicUnit = beyonce, Rating = 5.0 },

                new Review { Creator = ivan, MusicUnit = jid, Rating = 6.0 },
                new Review { Creator = petar, MusicUnit = jid, Rating = 10.0 },
                new Review { Creator = maria, MusicUnit = jid, Rating = 9.0 },
                new Review { Creator = martin, MusicUnit = jid, Rating = 10.0 },

                new Review { Creator = ivan, MusicUnit = jayZ, Rating = 8.0 },
                new Review { Creator = petar, MusicUnit = jayZ, Rating = 6.0 },
                new Review { Creator = martin, MusicUnit = jayZ, Rating = 7.0 },

                new Review { Creator = ivan, MusicUnit = kendrick, Rating = 4.0 },
                new Review { Creator = maria, MusicUnit = kendrick, Rating = 10.0 },
                new Review { Creator = martin, MusicUnit = kendrick, Rating = 8.0 },

                new Review { Creator = petar, MusicUnit = amine, Rating = 8.0 },
                new Review { Creator = maria, MusicUnit = amine, Rating = 7.0 },

                new Review { Creator = petar, MusicUnit = macMiller, Rating = 7.0 },
                new Review { Creator = maria, MusicUnit = macMiller, Rating = 3.0 },

                new Review { Creator = ivan, MusicUnit = sza, Rating = 10.0 },
                new Review { Creator = petar, MusicUnit = sza, Rating = 8.0 },

                new Review { Creator = ivan, MusicUnit = kaliUchis, Rating = 9.0 },
                new Review { Creator = petar, MusicUnit = kaliUchis, Rating = 5.0 },
                new Review { Creator = maria, MusicUnit = kaliUchis, Rating = 9.0 },
            };            // Create the recommendation service            foreach (var review in reviews)            {                reviewRepository.Insert(review);            }            var expectedRecommendations = new List<MusicUnit>
            {
                beyonce,
                kaliUchis,
                amine
            };            var recommendationService = new RecommendationService(userRepository, musicUnitRepository, reviewRepository);            // Get recommendations for user4                                                          await recommendationService.Setup();            var recommendations = await recommendationService.GetRecommendationsForUser(martin, 3);                        // Assert the recommendations            Assert.AreEqual(3, recommendations.Count);            CollectionAssert.AreEqual(expectedRecommendations, recommendations);        }

    }

}

