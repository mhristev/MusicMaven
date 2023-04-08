﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
{
    {

        public void OnGet(string id)
        {
            User? user = _userService.GetUserById(id);
            if (user != null)
                List<Review> reviews = _reviewService.GetReviewsForUser(user).ToList();
                Reviews = reviews.Select(review => ReviewDTO.FromReview(review)).ToList();
                LastReviewedMusicUnits = _musicUnitService.GetLastReviewedMusicUnits(reviews, 5).Select(unit => MusicUnitDTO.FromMusicUnit(unit)).ToList();
                AverageRating = _reviewService.GetAverageRatingForReviews(reviews);
            }

        }
    }
}