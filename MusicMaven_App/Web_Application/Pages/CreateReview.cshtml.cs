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
using Business_Logic.Interfaces.IServices;
using System.Globalization;

namespace Web_Application.Pages
{
    [Authorize]
	public class CreateReviewModel : PageModel
    {
        private IMusicUnitService _musicUnitService;
        private IReviewService _reviewService;
        private IUserService _userService;

        public CreateReviewModel(IUserService us, IMusicUnitService musicUnitService, IReviewService reviewService)
        {
            _userService = us;
            _reviewService = reviewService;
            _musicUnitService = musicUnitService;
        }

        public IActionResult OnPostCreateReview(string musicUnitId, ReviewDTO reviewDTO, string rating)
        {            if (double.TryParse(rating, NumberStyles.Any, CultureInfo.GetCultureInfo("fr-FR"), out double rating2)
)            {                // The string value was successfully converted to a double value                reviewDTO.Rating = rating2;                // Perform other validation and processing            }
            var test = reviewDTO.Rating;
            // TODO Fix current_user Id
            if (ModelState.IsValid)
            {
                string? id = HttpContext.User.FindFirst("Id")?.Value;
                if (!string.IsNullOrEmpty(id))
                {
                    MusicUnit? unit = _musicUnitService.GetMusicUnitWithId(musicUnitId);
                    if (id != null)
                    {
                        User? user = _userService.GetUserById(id);
                        if (user != null && unit != null)
                        {
                            _reviewService.AddReview(reviewDTO.Title, reviewDTO.Description, reviewDTO.Rating, unit, user);
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
