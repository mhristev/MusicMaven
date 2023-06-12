using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using Microsoft.AspNetCore.Authorization;using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;using Web_Application.DTOs.MusicUnitDTOs;using Business_Logic.Interfaces.IServices;using Business_Logic.Interfaces;using Web_Application.Helpers;using Business_Logic.Enums;namespace Web_Application.Pages
{    public class ProfileModel : PageModel
    {        private IReviewService _reviewService;        private IUserService _userService;        private IMusicUnitService _musicUnitService;        private ICurrentUserProvider currentUserProvider;        public List<ReviewDTO> Reviews { get; private set; }        public List<MusicUnitDTO> LastReviewedMusicUnits { get; private set; }        public double AverageRating { get; private set; }        public UserDTO OpenedUser { get; private set; }        public UserDTO CurrentUser { get; private set; }        public ProfileModel(IReviewService reviewService, IUserService userService, IMusicUnitService musicUnitService, ICurrentUserProvider currentUserProvider)        {            _reviewService = reviewService;            _userService = userService;            _musicUnitService = musicUnitService;            this.currentUserProvider = currentUserProvider;        }        public IActionResult OnGetGoToMusicUnit(string id, MUSIC_UNIT_TYPE unitType)
        {            switch (unitType)
            {                case MUSIC_UNIT_TYPE.ALBUM:                    // Redirect to the Album page                    return RedirectToPage(PageRoutes.SingleAlbum, new { id = id });                case MUSIC_UNIT_TYPE.SONG:                    // Redirect to the Song page                    return RedirectToPage(PageRoutes.SingleSong, new { id = id });                case MUSIC_UNIT_TYPE.ARTIST:                    // Redirect to the Artist page                    return RedirectToPage(PageRoutes.SingleArtist, new { id = id });                default:                    // Redirect to the home page                    return RedirectToPage(PageRoutes.Profile);
            }
        }

        public void OnGet(string id)
        {

            User? user = _userService.GetUserById(id);
            if (user != null)            {
                OpenedUser = UserDTO.FromUser(user);                List<Review> reviews = _reviewService.GetReviewsForUser(user).ToList();
                Reviews = reviews.Select(review => ReviewDTO.FromReview(review)).ToList();
                LastReviewedMusicUnits = _musicUnitService.GetLastReviewedMusicUnits(reviews, 5).Select(unit => MusicUnitDTO.FromMusicUnit(unit)).ToList();
                AverageRating = _reviewService.GetAverageRatingForReviews(reviews);
                string? currId = currentUserProvider.GetCurrentUserId();
                if (currId != null)                {                    User? currUser = _userService.GetUserById(currId);                    if (currUser != null)                    {                        CurrentUser = UserDTO.FromUser(currUser);                    }
                }
            }
            else            {

            }

        }

        public IActionResult OnPostFollowUser(string id)        {
            User? fromUser = _userService.GetUserById(currentUserProvider.GetCurrentUserId());
            string profileId = id;
            if (fromUser != null)            {
                User? toFollow = _userService.GetUserById(id);
                if (toFollow != null)                {
                    _userService.FollowUserFromUser(toFollow, fromUser);
                }
            }            string previousUrl = Request.Headers["Referer"].ToString();
            // redirect the user back to the previous page
            return Redirect(previousUrl);
        }

        public IActionResult OnPostUnFollowUser(string id)        {
            User? fromUser = _userService.GetUserById(currentUserProvider.GetCurrentUserId());
            string profileId = id;
            if (fromUser != null)            {
                User? toUnfollow = _userService.GetUserById(id);
                if (toUnfollow != null)                {
                    _userService.UnFollowUserFromUser(toUnfollow, fromUser);
                }
            }
            string previousUrl = Request.Headers["Referer"].ToString();
            // redirect the user back to the previous page
            return Redirect(previousUrl);
        }
    }
}
