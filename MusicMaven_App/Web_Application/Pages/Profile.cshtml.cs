using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using Microsoft.AspNetCore.Authorization;using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;using Web_Application.DTOs.MusicUnitDTOs;namespace Web_Application.Pages
{    public class ProfileModel : PageModel
    {        private ReviewService _reviewService;        private UserService _userService;        private MusicUnitService _musicUnitService;        public List<ReviewDTO> Reviews { get; private set; }        public List<MusicUnitDTO> LastReviewedMusicUnits { get; private set; }        public double AverageRating { get; private set; }        public ProfileModel(ReviewService reviewService, UserService userService, MusicUnitService musicUnitService)        {            _reviewService = reviewService;            _userService = userService;            _musicUnitService = musicUnitService;        }        

        public void OnGet(string id)
        {
            User? user = _userService.GetUserById(id);
            if (user != null)            {
                List<Review> reviews = _reviewService.GetReviewsForUser(user).ToList();
                Reviews = reviews.Select(review => ReviewDTO.FromReview(review)).ToList();
                LastReviewedMusicUnits = _musicUnitService.GetLastReviewedMusicUnits(reviews, 5).Select(unit => MusicUnitDTO.FromMusicUnit(unit)).ToList();
                AverageRating = _reviewService.GetAverageRatingForReviews(reviews);
            }

        }
    }
}
