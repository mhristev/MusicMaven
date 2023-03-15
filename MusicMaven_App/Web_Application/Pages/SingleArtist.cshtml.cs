using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages
{
    public class SingleArtistModel : PageModel
    {
        private ReviewService reviewService = ReviewService.Instance;
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        public MusicUnitDTO CurrMusicUnit { get; set; }

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }
        public void OnGet(string id)
        {
            try
            {
                CurrMusicUnit = MusicUnitDTO.FromMusicUnit(musicUnitService.GetMusicUnitWithId(id));
            } catch (ArgumentException ex)
            {
                
            }

        }
        public IActionResult OnPost(string id)
        {
            if (ModelState.IsValid)
            {
                reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, id, "creatorId");
                return RedirectToPage("/Reviews");
            }
            return Page();
        }
    }
}
