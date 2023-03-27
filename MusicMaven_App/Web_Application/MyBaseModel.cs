using System;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;

namespace Web_Application
{
    public class MyBaseModel : PageModel
    {
        public IActionResult OnPostLikeReview(string reviewId)
        {
            string? id = HttpContext.Session.GetString("UserId");
            if (!string.IsNullOrEmpty(id))
            {
                ReviewService reviewService = ReviewService.Instance;
                reviewService.AddLikeToReviewFromCurrentUser(reviewId, userId: id);
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

        public IActionResult OnPostCreateReview(string musicUnitId, ReviewDTO reviewDTO)
        {
            // TODO Fix current_user Id
            if (ModelState.IsValid)
            {
                ReviewService reviewService = ReviewService.Instance;
                string? id = HttpContext.Session.GetString("UserId");
                id = "123";
                if (!string.IsNullOrEmpty(id))
                {
                    reviewService.AddReview(reviewDTO.Title, reviewDTO.Description, reviewDTO.Rating, musicUnitId, id);
                    string previousUrl = Request.Headers["Referer"].ToString();
                    // redirect the user back to the previous page
                    return Redirect(previousUrl);
                }
            }
            return RedirectToPage("/Index");

        }
    }
}

