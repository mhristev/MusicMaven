using Business_Logic.Enums;
using Business_Logic.Factories;
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
        private static ReviewService instance;
        private List<Review> reviews;
        private ReviewFactory reviewFactory;
        private UserService userService = UserService.Instance;
        

        private ReviewService()
        {
            reviewFactory = new ReviewFactory();
            MusicUnitService musicUnitService = MusicUnitService.Instance;
            Artist tyler = (Artist)musicUnitService.GetAllMusicUnits().First();
            //Artist artist = new Artist(Guid.NewGuid().ToString(), "Tyler the Creator", "images/tyler", MUSIC_UNIT_TYPE.ARTIST, ARTIST_TYPE.SOLO, 9);

        //    User johnDoe = new User("1", "johndoe", "JohnDoe@gmail.com", "password1", new List<User>(), USER_TYPE.NORMAL);
        //    User janeDoe = new User("2", "janedoe", "JaneDoe@mail.com", "password1", new List<User>(), USER_TYPE.NORMAL);

            reviews = new List<Review>() {
                reviewFactory.CreateReview("Great Album","I loved this album so much.", tyler, userService.GetCurrentUser(), 8.3),
                reviewFactory.CreateReview("Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", tyler, userService.GetCurrentUser(), 4.1)
            };

                               
        }

        public static ReviewService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(ReviewService))
                    {
                        if (instance == null)
                        {
                            instance = new ReviewService();
                        }
                    }
                }
                return instance;
            }
        }

        public List<Review> GetAll()
        {
            return reviews.OrderByDescending(r => r.CreationDate).ToList();
        }

        public void AddReview(string title, string description, double rating, string musicUnitId, string creatorId)
        {
            MusicUnit unit = MusicUnitService.Instance.GetMusicUnitWithId(musicUnitId);
            Review r = reviewFactory.CreateReview(title, description, unit, userService.GetCurrentUser(), rating);
            reviews.Add(r);
        }


        public List<Review> GetReviewsForMusicUnit(string id)
        {
            return reviews.Where(review => review.MusicUnit.Id == id).OrderByDescending(r => r.CreationDate).ToList();
        }

        public void AddLikeToReviewFromCurrentUser(string reviewId, string userId)
        {
            Review r = reviews.Where(review => review.Id == reviewId).First();
            foreach (User u in r.LikedBy) {
                if (u.Id == userId)
                {
                    r.LikedBy.Remove(u);
                    return;
                }
            }
            User? user = userService.GetUserById(userId);
            if (user != null) {
                r.LikedBy.Add(user);
            }
        }
    }
}
