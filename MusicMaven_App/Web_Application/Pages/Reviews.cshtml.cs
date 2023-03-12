using Business_Logic.Models.MusicUnits;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;
using Business_Logic.Enums;

namespace Web_Application.Pages
{
    public class ReviewsModel : PageModel
    {
        private ReviewService reviewService = new ReviewService();
        public List<ReviewDTO> Reviews { get; set; } = new List<ReviewDTO>();

        List<ReviewDTO> serviceMethod()
        {
            // Create some users
            User johnDoe = new User("1", "johndoe", "JohnDoe@gmail.com", "password1", new List<User>());
            User janeDoe = new User("2", "janedoe", "JaneDoe@mail.com", "password1", new List<User>());

            // Create a music unit
            Artist artist = new Artist("1", "Tyler the Creator", "images/tyler", ARTIST_TYPE.SOLO, new List<Album>(), 9, new List<Review>());

            // Create a list of reviews
            List<Review> reviews = new List<Review>()
            {
                new Review("1", "Great album!", "I loved this album so much.", new DateTime(2022, 03, 01), 4.5, artist, johnDoe, new List<User> { janeDoe }),
                new Review("2", "Disappointing", "I was really looking forward to this album, but it didn't meet my expectations.", new DateTime(2022, 03, 02), 2.5, artist, janeDoe, new List<User>()),
                new Review("3", "Amazing!", "This album exceeded all of my expectations. I can't stop listening to it!", new DateTime(2022, 03, 03), 5.0, artist, johnDoe, new List<User> { janeDoe, johnDoe }),
                new Review("4", "Not my cup of tea", "This album just isn't my style. I'm sure others will enjoy it though.", new DateTime(2022, 03, 04), 3.0, artist, janeDoe, new List<User>()),
                new Review("5", "Meh", "This album was just okay. Nothing special.", new DateTime(2022, 03, 05), 3.5, artist, johnDoe, new List<User> { janeDoe })
            };
            List<ReviewDTO> reviewDTOs = new List<ReviewDTO>();

            foreach (Review review in reviews)
            {
                ReviewDTO reviewDTO = new ReviewDTO()
                {
                    Id = review.Id,
                    Title = review.Title,
                    Content = review.Content,
                    CreationDate = review.CreationDate,
                    Rating = review.Rating,
                    MusicUnit = new MusicUnitDTO()
                    {
                        Id = review.MusicUnit.Id,
                        Name = review.MusicUnit.Name,
                    },
                    Creator = new UserDTO()
                    {
                        Id = review.Creator.Id,
                        Username = review.Creator.Username
                    },
                    LikedBy = review.LikedBy.Select(user => new UserDTO()
                    {
                        Id = user.Id,
                        Username = user.Username
                    }).ToList()
                };

                reviewDTOs.Add(reviewDTO);
            }

            return reviewDTOs;
        }
        public void OnGet()
        {
            Reviews = serviceMethod();
             
        }

        
    }
}
