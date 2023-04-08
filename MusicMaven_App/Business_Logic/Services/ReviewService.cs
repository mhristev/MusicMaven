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
        
       // private List<Review> reviews;
        private ReviewFactory _reviewFactory;
        // private UserService userService = UserService.Instance;
        private IReviewRepository _reviewRepository;
        private ICurrentUserProvider _currentUserProvider;

        public ReviewService(IReviewRepository reviewRepository, ICurrentUserProvider currentUserProvider)
        {
            _reviewRepository = reviewRepository;
            _currentUserProvider = currentUserProvider;
            _reviewFactory = new ReviewFactory();
        }

        //private ReviewService()
        //{
        //    reviewFactory = new ReviewFactory();
        //    MusicUnitService musicUnitService = MusicUnitService.Instance;
        //    Artist tyler = (Artist)musicUnitService.GetAllMusicUnits().First();
        //    //Artist artist = new Artist(Guid.NewGuid().ToString(), "Tyler the Creator", "images/tyler", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 9);

        ////    User johnDoe = new User("1", "johndoe", "JohnDoe@gmail.com", "password1", new List<User>(), USER_TYPE.NORMAL);
        ////    User janeDoe = new User("2", "janedoe", "JaneDoe@mail.com", "password1", new List<User>(), USER_TYPE.NORMAL);

        //    //reviews = new List<Review>() {
        //    //    reviewFactory.CreateReview("Great Album","I loved this album so much.", tyler, userService.GetCurrentUser(), 8.3),
        //    //    reviewFactory.CreateReview("Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", tyler, userService.GetCurrentUser(), 4.1)
        //    //};
        //    reviews = new List<Review>() {
        //        reviewFactory.CreateReview("Great Album","I loved this album so much.", tyler, new User("1", "", "", "", new(), USER_TYPE.NORMAL) , 8.3),
        //        reviewFactory.CreateReview("Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", tyler, new User("1", "", "", "", new(), USER_TYPE.NORMAL), 4.1)
        //    };


        //}

        public List<Review> GetAll()
        {
            return _reviewRepository.GetAll();
           // return reviews.OrderByDescending(r => r.CreationDate).ToList();
        }

        public void AddReview(string title, string description, double rating, MusicUnit musicUnit, User creator)
        {
            Review r = _reviewFactory.CreateReview(title, description, musicUnit, creator, rating);
            // reviews.Add(r);
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
