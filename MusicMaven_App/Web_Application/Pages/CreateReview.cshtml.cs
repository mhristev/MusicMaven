using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;

namespace Web_Application.Pages
{
    [Authorize]
	public class CreateReviewModel : PageModel
    {
        public IActionResult OnPostCreateReview(string musicUnitId, ReviewDTO reviewDTO)
        {
            // TODO Fix current_user Id
            if (ModelState.IsValid)
            {
                ReviewService reviewService = ReviewService.Instance;
                string? id = HttpContext.User.FindFirst("Id")?.Value;
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
