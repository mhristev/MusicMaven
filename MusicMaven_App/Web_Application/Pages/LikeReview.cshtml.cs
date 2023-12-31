﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business_Logic.Interfaces.IServices;

namespace Web_Application.Pages
{
    [Authorize]
	public class LikeReviewModel : PageModel
    {
        private IReviewService _reviewService;
        public LikeReviewModel(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        public IActionResult OnPostLikeReview(string reviewId)
        {
            // Wont work if there is an active session because user session id is 1234
            // but in the test db now it generates random string and even though its the same name the users have different id
            var user = HttpContext.User.FindFirst("Id");
            if (user != null)
            {
                string id = user.Value;
                Review? review = _reviewService.GetReviewWithId(reviewId);
                if (review != null)
                {
                        _reviewService.LikeReviewByCurrentUser(review);
                }
            }
            else
            {
                return RedirectToPage("/SignIn");
            }

            // TODO AJAX file to refresh only the Likes
            string previousUrl = Request.Headers["Referer"].ToString();
            // redirect the user back to the previous page
            return Redirect(previousUrl);
        }
    }
}
