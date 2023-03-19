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

namespace Web_Application.Pages.Single
{
	public class SingleSongModel : PageModel
    {
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        private ReviewService reviewService = ReviewService.Instance;
        public SongDTO Song { get; private set; } = new SongDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }

        public void OnGet(string id)
        {
            Song = SongDTO.FromSong((Song)musicUnitService.GetMusicUnitWithId(id));
            Reviews = reviewService.GetReviewsForMusicUnit(id).Select(r => ReviewDTO.FromReview(r)).ToList();
        }

        public void OnPost(string id)
        {
            if (ModelState.IsValid)
            {
                reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, id, "creatorId");
            }
            OnGet(id);
        }
    }
}
