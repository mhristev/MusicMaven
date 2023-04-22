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
using Business_Logic.Interfaces.IServices;

namespace Web_Application.Pages.Single
{
	public class SingleAlbumModel : PageModel
    {
        private IMusicUnitService _musicUnitService;
        private IReviewService _reviewService;
        private IUserService _userService;

        public List<SongDTO> Songs { get; private set; } = new List<SongDTO>();
        public AlbumDTO Album { get; private set; } = new AlbumDTO();
        public List<ReviewDTO> Reviews { get; private set; } = new List<ReviewDTO>();

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }


        public SingleAlbumModel(IUserService userService, IMusicUnitService musicUnitService, IReviewService reviewService)
        {
            this._userService = userService;
            this._reviewService = reviewService;
            this._musicUnitService = musicUnitService;
        }
        public void OnGet(string id)
        {
            Album? album = (Album?)_musicUnitService.GetMusicUnitWithId(id);
            if (album != null) {
                Album = AlbumDTO.FromAlbum(album);
                Songs = _musicUnitService.GetSongsInAlbum(album).Select(s => SongDTO.FromSong(s)).ToList();
                MusicUnit? musicUnit = _musicUnitService.GetMusicUnitWithId(id);
                if (musicUnit != null)
                {
                    Reviews = _reviewService.GetReviewsForMusicUnit(musicUnit).Select(r => ReviewDTO.FromReview(r)).ToList();
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
                    User? currUser = _userService.GetUserById(currUserId);
                    MusicUnit? unit = _musicUnitService.GetMusicUnitWithId(id);
                    if (currUser != null && unit != null)
                    {
                        _reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, unit, currUser);
                    }
                }
            }
            OnGet(id);
        }

    }
}
