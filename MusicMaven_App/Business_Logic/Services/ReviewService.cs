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

        public void AddReview(string title, string description, double rating, MusicUnit musicUnit, User creator)
        {
            Review r = reviewFactory.CreateReview(title, description, musicUnit, creator, rating);
            reviews.Add(r);
        }


        public List<Review> GetReviewsForMusicUnit(MusicUnit unit)
        {
            return reviews.Where(review => review.MusicUnit.Id == unit.Id).OrderByDescending(r => r.CreationDate).ToList();
        }

        public Review? GetReviewWithId(string id)
        {
            return reviews.FirstOrDefault(r => r.Id == id);
        }

        public void AddLikeToReviewFromUser(Review review, User user)
        {
            foreach (User u in review.LikedBy)
            {
                if (u.Id == user.Id)
                {
                    review.LikedBy.Remove(u);
                    return;
                }
            }
           
            review.LikedBy.Add(user);   
        }
    }
}
