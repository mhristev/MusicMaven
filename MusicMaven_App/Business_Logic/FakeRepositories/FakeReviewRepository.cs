using System;
using System.Reflection.Metadata;
using Business_Logic.Enums;using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
    public class FakeReviewRepository: IReviewRepository
    {
        private readonly List<Review> _reviews = new List<Review>();
        private IArtistRepository _artistRepository;
        //private IMusicUnitRepository musicUnitRepository;
        private IUserRepository _userRepository;

        public FakeReviewRepository(IUserRepository userRepository, IArtistRepository artistRepository)
        {            _userRepository = userRepository;            _artistRepository = artistRepository;
            User? admin = _userRepository.GetById("1");
            Artist? tyler = _artistRepository.GetById("1");
            if (admin != null && tyler != null)            {                _reviews.Add(new Review("1", "Great Album", "I loved this album so much.", DateTime.Today, 8.1, tyler, admin, new List<User>()));                _reviews.Add(new Review("2", "Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", DateTime.Today, 2.2, tyler, admin, new List<User>()));            }
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
        }        public List<Review> GetReviewsForMusicUnitId(string id)        {            return _reviews                .Where(review => review.MusicUnit.Id == id)                .OrderByDescending(r => r.CreationDate)                .ToList();        }        public List<Review> GetReviewsForuserId(string id)        {            return _reviews                .Where(review => review.Creator.Id == id)                .OrderByDescending(r => r.CreationDate)                .ToList();        }        public void Insert(Review entity)
        {
            _reviews.Add(entity);
        }        public void LikeReviewIdByUserId(string reviewId, string userId)        {            Review? review = _reviews.FirstOrDefault(r => r.Id == reviewId);            if (review != null)            {                User? user = _userRepository.GetById(userId);                if (user != null)                {                    if (review.LikedBy.Any(u => u.Id == userId))                    {                        review.LikedBy.RemoveAll(u => u.Id == userId);                    }                    else                    {                        review.LikedBy.Add(user);                    }                }            }        }        public void Update(Review entity)
        {            Review? review = _reviews.FirstOrDefault(r => r.Id == entity.Id);
            if (review != null)
            {                review.Title = entity.Title;                review.Description = entity.Description;                review.Rating = entity.Rating;                review.LikedBy = entity.LikedBy;
            }
        }
    }
}

