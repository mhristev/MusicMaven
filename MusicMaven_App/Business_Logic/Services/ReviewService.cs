using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Services
{
    public class ReviewService
    {
        private IReviewRepository _reviewRepository;
        private ICurrentUserProvider _currentUserProvider;

        public ReviewService(IReviewRepository reviewRepository, ICurrentUserProvider currentUserProvider)
        {
            _reviewRepository = reviewRepository;
            _currentUserProvider = currentUserProvider;
        }

        public List<Review> GetAll()
        {
            return _reviewRepository.GetAll();
        }

        public void AddReview(string title, string description, double rating, MusicUnit musicUnit, User creator)
        {
            Review r = ReviewFactory.CreateReview(title, description, musicUnit, creator, rating);
            _reviewRepository.Insert(r);
        }


        public List<Review> GetReviewsForMusicUnit(MusicUnit unit)
        {
            List<Review> result = _reviewRepository.GetReviewsForMusicUnitId(unit.Id);
            return result;
        }

        public Review? GetReviewWithId(string id)
        {
            return _reviewRepository.GetById(id);
        }

        public void LikeReviewByCurrentUser(Review review)
        {
            string? userId = _currentUserProvider.GetCurrentUserId();
            if (userId != null)
            {
                _reviewRepository.LikeReviewIdByUserId(review.Id, userId);
            }
        }

        public List<Review> GetReviewsForUser(User user)
        {
            return _reviewRepository.GetReviewsForuserId(user.Id);
        }

        public double GetAverageRatingForReviews(List<Review> reviews)        {            if (reviews == null || reviews.Count == 0)            {                return 0.0;            }            double totalRating = 0.0;            foreach (var review in reviews)            {                totalRating += review.Rating;            }            double averageRating = totalRating / reviews.Count;            return Math.Round(averageRating, 2);
        }
    }
}
