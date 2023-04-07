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
        private MusicUnitService _musicUnitService;
        private ReviewService _reviewService;
        private UserService _userService;

        public SongDTO Song { get; private set; } = new SongDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }

        public SingleSongModel(UserService us, ReviewService reviewService, MusicUnitService musicUnitService)
        {
            _userService = us;
            _musicUnitService = musicUnitService;
            _reviewService = reviewService;
        }

        public void OnGet(string id)
        {
            Song? song = (Song?)_musicUnitService.GetMusicUnitWithId(id);
            if (song != null)
            {
                Song = SongDTO.FromSong(song);
                MusicUnit? unit = _musicUnitService.GetMusicUnitWithId(id);
                if (unit != null)
                {
                    Reviews = _reviewService.GetReviewsForMusicUnit(unit).Select(r => ReviewDTO.FromReview(r)).ToList();
                }
            }
        }

        public void OnPost(string id)
        {
            
            if (ModelState.IsValid)
            {
                MusicUnit? unit = _musicUnitService.GetMusicUnitWithId(id);
                string? userId = HttpContext.User.FindFirst("Id")?.Value;
                User? currUser = null;

                if (userId != null) {
                    currUser = _userService.GetUserById(userId);
                }
                if (currUser != null && unit != null)
                {
                    _reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, unit, currUser);
                }
            }
            OnGet(id);
        }

    }
}
