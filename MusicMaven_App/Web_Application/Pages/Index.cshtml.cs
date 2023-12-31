﻿using Business_Logic.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;
using Web_Application.Pages.Shared;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Enums;using Web_Application.Helpers;using Business_Logic.Interfaces;using Business_Logic.Models.MusicUnits;using System.Security.AccessControl;using Microsoft.Extensions.Caching.Memory;namespace Web_Application.Pages
{
    public class IndexModel : PageModel
    {
        private IMusicUnitService musicUnitService;
        private IReviewService reviewService;
        private IRecommendationService recommendationService;
        private ICurrentUserProvider currentUserProvider;
        private IUserService userService;

        public List<ArtistDTO> Artists { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        public List<AlbumDTO> NewAlbums { get; private set; }
        public List<MusicUnitDTO> HighestRatedMusicUnits { get; private set; }

        public IndexModel(IMusicUnitService musicUnitService, IReviewService reviewService, ICurrentUserProvider currentUserProvider, IUserService userService)        {
            this.musicUnitService = musicUnitService;
            this.reviewService = reviewService;
           // this.recommendationService = recommendationService;
            this.currentUserProvider = currentUserProvider;
            this.userService = userService;
            Artists = new List<ArtistDTO>();
        }

        public async Task OnGet()
        {
            //Artists = musicUnitService.GetArtists().Select(a => ArtistDTO.FromArtist(a)).ToList();
            Reviews = reviewService.GetLatestReviews(15).Select(r => ReviewDTO.FromReview(r)).ToList();
            NewAlbums = musicUnitService.GetNewReleasedAlbums(5).Select(a => AlbumDTO.FromAlbum(a)).ToList();
            HighestRatedMusicUnits = musicUnitService.GetHighestRatedMusicUnits(5).Select(u => MusicUnitDTO.FromMusicUnit(u)).ToList();
        }

        public IActionResult OnGetHighestRatedUnit(string id, MUSIC_UNIT_TYPE unitTyoe)            {
            switch(unitTyoe)
            {                case MUSIC_UNIT_TYPE.ALBUM:                    // Redirect to the Album page                    return RedirectToPage(PageRoutes.SingleAlbum, new { id = id });                case MUSIC_UNIT_TYPE.SONG:                    // Redirect to the Song page                    return RedirectToPage(PageRoutes.SingleSong, new { id = id });                case MUSIC_UNIT_TYPE.ARTIST:                    // Redirect to the Artist page                    return RedirectToPage(PageRoutes.SingleArtist, new { id = id });                default:                    // Redirect to the home page                    return RedirectToPage(PageRoutes.Index);
            }

        }

    }
}