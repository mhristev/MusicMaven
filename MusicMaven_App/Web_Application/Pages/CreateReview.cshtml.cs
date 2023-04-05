using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
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
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        private ReviewService reviewService = ReviewService.Instance;
        private UserService userService;

        public CreateReviewModel(UserService us)
        {
            userService = us;
        }

        public IActionResult OnPostCreateReview(string musicUnitId, ReviewDTO reviewDTO)
        {
            // TODO Fix current_user Id
            if (ModelState.IsValid)
            {
                string? id = HttpContext.User.FindFirst("Id")?.Value;
                if (!string.IsNullOrEmpty(id))
                {
                    MusicUnit? unit = musicUnitService.GetMusicUnitWithId(musicUnitId);
                    if (id != null)
                    {
                        User? user = userService.GetUserById(id);
                        if (user != null && unit != null)
                        {
                            reviewService.AddReview(reviewDTO.Title, reviewDTO.Description, reviewDTO.Rating, unit, user);
                        }
                    }
                    string previousUrl = Request.Headers["Referer"].ToString();
                    // redirect the user back to the previous page
                    return Redirect(previousUrl);
                }
            }
            return RedirectToPage("/Index");

        }
    }
}
