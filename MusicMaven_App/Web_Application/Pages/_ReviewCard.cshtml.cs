using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.Models;

namespace Web_Application.Pages
{
	public class _ReviewCardModel : PageModel
    {
        public ReviewDTO reviewDTO { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostLike(string reviewId)
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
            return RedirectToPage("/Index");
        }
    }
}
