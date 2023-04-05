using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;
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
        UserService userService;
        public List<SongDTO> Songs { get; private set; } = new List<SongDTO>();
        public AlbumDTO Album { get; private set; } = new AlbumDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }


        public SingleAlbumModel(UserService userService)
        {
            this.userService = userService; 
        }
        public void OnGet(string id)
        {
            Album? album = (Album?)musicUnitService.GetMusicUnitWithId(id);
            if (album != null) {
                Album = AlbumDTO.FromAlbum(album);
                Songs = musicUnitService.GetSongsInAlbum(album).Select(s => SongDTO.FromSong(s)).ToList();
                MusicUnit? musicUnit = musicUnitService.GetMusicUnitWithId(id);
                if (musicUnit != null)
                {
                    Reviews = reviewService.GetReviewsForMusicUnit(musicUnit).Select(r => ReviewDTO.FromReview(r)).ToList();
                }
            }
        }

        public void OnPost(string id)
        {
            
            if (ModelState.IsValid)
            {
                string? currUserId = HttpContext.User.FindFirst("Id")?.Value;
                if (currUserId != null)
                {
                    User? currUser = userService.GetUserById(currUserId);
                    MusicUnit? unit = musicUnitService.GetMusicUnitWithId(id);
                    if (currUser != null && unit != null)
                    {
                        reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, unit, currUser);
                    }
                }
            }
            OnGet(id);
        }

        public void OnPostLike(string reviewId, string albumId)
        {
            Review? review = reviewService.GetReviewWithId(reviewId);
            string? currUserId = HttpContext.User.FindFirst("Id")?.Value;
            User? currUser = null;
            if (currUserId != null)
            {
                currUser = userService.GetUserById(currUserId);
            }
            if (currUser != null && review != null)
            {
                reviewService.AddLikeToReviewFromUser(review, currUser);
            }
            // TODO AJAX file to refresh only the Likes
            OnGet(albumId);
        }
    }
}
