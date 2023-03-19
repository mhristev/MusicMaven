using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages.Single
{
	public class SingleAlbumModel : PageModel
    {
        MusicUnitService musicUnitService = MusicUnitService.Instance;
        ReviewService reviewService = ReviewService.Instance;
        public List<SongDTO> Songs { get; private set; } = new List<SongDTO>();
        public AlbumDTO Album { get; private set; } = new AlbumDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }

        public void OnGet(string id)
        {
            Album = AlbumDTO.FromAlbum((Album)musicUnitService.GetMusicUnitWithId(id));
            Songs = musicUnitService.GetSongsInAlbumId(id).Select(s => SongDTO.FromSong(s)).ToList();
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
