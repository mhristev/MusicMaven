using Business_Logic.Enums;
using Business_Logic.Interfaces;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs.MusicUnitDTOs;using Web_Application.Helpers;namespace Web_Application.Pages.Shared
{
    public class DiscoverModel : PageModel
    {        private IRecommendationService recommendationService;        private IUserService userService;        private ICurrentUserProvider currentUserProvider;        private IReviewService reviewService;        public DiscoverModel(IRecommendationService recommendationService, IUserService userService, ICurrentUserProvider currentUserProvider, IReviewService reviewService)        {            this.recommendationService = recommendationService;            this.userService = userService;            this.currentUserProvider = currentUserProvider;            this.reviewService = reviewService;        }        public Dictionary<MusicUnitDTO, string> Recommendations { get; private set; }        public async Task OnGet()
        {
            Recommendations = new Dictionary<MusicUnitDTO, string>();
            string? id = currentUserProvider.GetCurrentUserId();
            if (id != null)            {                List<MusicUnit> recommendations = await recommendationService.GetRecommendationsForUser(userService.GetUserById(id), 10);                foreach (MusicUnit musicUnit in recommendations)                {                    string body = reviewService.GetDescriptionOfHighestRatedReviewForMusicUnit(musicUnit);                    MusicUnitDTO dto = MusicUnitDTO.FromMusicUnit(musicUnit);                    Recommendations.Add(dto, body);                }                    
            }
        }

        public IActionResult OnGetRedirectToMusicUnit(string id, MUSIC_UNIT_TYPE unitType)        {
            switch (unitType)
            {                case MUSIC_UNIT_TYPE.ALBUM:                    // Redirect to the Album page                    return RedirectToPage(PageRoutes.SingleAlbum, new { id = id });                case MUSIC_UNIT_TYPE.SONG:                    // Redirect to the Song page                    return RedirectToPage(PageRoutes.SingleSong, new { id = id });                case MUSIC_UNIT_TYPE.ARTIST:                    // Redirect to the Artist page                    return RedirectToPage(PageRoutes.SingleArtist, new { id = id });                default:                    // Redirect to the home page                    return RedirectToPage(PageRoutes.Discover);
            }
        }
    }
}
