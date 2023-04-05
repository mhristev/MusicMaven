using System;
using System.Reflection.Metadata;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
    public class FakeReviewRepository:IRepository<Review>
    {
        private List<Review> _reviews = new List<Review>();
        private IMusicUnitRepository musicUnitRepository;
        private IRepository<User> userRepository;

        public FakeReviewRepository(IMusicUnitRepository musicUnitRepository, IRepository<User> userRepository)
        {
            ReviewFactory factory = new ReviewFactory();

            this.musicUnitRepository = musicUnitRepository;
            this.userRepository = userRepository;
            User? creator = userRepository.GetById("2");
            MusicUnit? unit = musicUnitRepository.GetMusicUnitByid("1");
            if (creator != null && unit != null)
            {
                _reviews.Add(new Review("1", "Great Album", "I loved this album so much.", DateTime.Today, 8.1, unit, creator, new List<User>()));
                _reviews.Add(new Review("2", "Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", DateTime.Today, 2.2, unit, creator, new List<User>()));

            }
        }

        public void Delete(string id)
        {
            Review? reviewToDelete = _reviews.FirstOrDefault(r => r.Id == id);
            if (reviewToDelete != null)
            {
                _reviews.Remove(reviewToDelete);
            }
        }

        public List<Review> GetAll()
        {
            return _reviews;
        }

        public Review? GetById(string id)
        {
            return _reviews.FirstOrDefault(review => review.Id == id);
        }

        public void Insert(Review entity)
        {
            _reviews.Add(entity);
        }

        public void Update(Review entity)
        {            Review? review = _reviews.FirstOrDefault(r => r.Id == entity.Id);
            if (review != null)
            {                review.Title = entity.Title;                review.Description = entity.Description;                review.Rating = entity.Rating;                review.LikedBy = entity.LikedBy;
            }
        }
    }
}

