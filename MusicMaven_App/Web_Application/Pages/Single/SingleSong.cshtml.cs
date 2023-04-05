using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business_Logic.Services;
using Web_Application.DTOs.MusicUnitDTOs;
using Business_Logic.Models.MusicUnits;
using Web_Application.DTOs;
using Business_Logic.Models;

namespace Web_Application.Pages.Single
{
	public class SingleSongModel : PageModel
    {
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        private ReviewService reviewService = ReviewService.Instance;
        private UserService userService;
        public SongDTO Song { get; private set; } = new SongDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }

        public SingleSongModel(UserService us)
        {
            userService = us;
        }

        public void OnGet(string id)
        {
            Song? song = (Song?)musicUnitService.GetMusicUnitWithId(id);
            if (song != null)
            {
                Song = SongDTO.FromSong(song);
                MusicUnit? unit = musicUnitService.GetMusicUnitWithId(id);
                if (unit != null)
                {
                    Reviews = reviewService.GetReviewsForMusicUnit(unit).Select(r => ReviewDTO.FromReview(r)).ToList();
                }
            }
        }

        public void OnPost(string id)
        {
            
            if (ModelState.IsValid)
            {
                MusicUnit? unit = musicUnitService.GetMusicUnitWithId(id);
                string? userId = HttpContext.User.FindFirst("Id")?.Value;
                User? currUser = null;

                if (userId != null) {
                    currUser = userService.GetUserById(userId);
                }
                if (currUser != null && unit != null)
                {
                    reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, unit, currUser);
                }
            }
            OnGet(id);
        }

        public void OnPostLike(string reviewId, string songId)
        {
            Review? review = reviewService.GetReviewWithId(reviewId);
            
            string? userId = HttpContext.User.FindFirst("Id")?.Value;
            User? currUser = userService.GetUserById(userId);
            if (review != null && userId == null && currUser != null)
            {
                reviewService.AddLikeToReviewFromUser(review, currUser);
            }
            // TODO AJAX file to refresh only the Likes
            OnGet(songId);
        }
    }
}
