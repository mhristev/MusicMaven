using Business_Logic.Interfaces;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.Services
{
    public class ReviewService : IReviewService
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
            Review review = new Review(Guid.NewGuid().ToString(), title, description, DateTime.UtcNow, rating, musicUnit, creator, new List<User>());
            _reviewRepository.Insert(review);
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
        }        public string GetDescriptionOfHighestRatedReviewForMusicUnit(MusicUnit musicUnit)        {            return _reviewRepository.GetDescriptionOfHighestRatedReviewForMusicUnit(musicUnit.Id);        }        public List<Review> GetLatestReviews(int count)        {            return _reviewRepository.GetLatestReviews(count);        }    }
}
