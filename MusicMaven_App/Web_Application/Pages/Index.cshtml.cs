using Business_Logic.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;
using Web_Application.Pages.Shared;

namespace Web_Application.Pages
{
    public class IndexModel : PageModel
    {
       // public Login2PartialModel Login2PartialModel { get; set; }
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        private ReviewService reviewService = ReviewService.Instance;
        public List<ArtistDTO> Artists { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        public List<AlbumDTO> NewAlbums { get; private set; }

        public string Username { get; set; }

        public void OnGet()
        {
            //Login2PartialModel = new Login2PartialModel();
            string? username = HttpContext.Session.GetString("Username");
            if (!string.IsNullOrEmpty(username))
            {
                Username = username;
            }
            Artists = musicUnitService.GetArtists().Select(a => ArtistDTO.FromArtist(a)).ToList();
            Reviews = reviewService.GetAll().Select(r => ReviewDTO.FromReview(r)).ToList();
            NewAlbums = musicUnitService.GetNewReleases().Select(a => AlbumDTO.FromAlbum(a)).ToList();
        }
       

        public IActionResult OnPostLike(string reviewId)
        {
            string? id = HttpContext.Session.GetString("UserId");
            if (!string.IsNullOrEmpty(id))
            {
                reviewService.AddLikeToReviewFromCurrentUser(reviewId, userId: id);
            } else
            {
                return RedirectToPage("/SignIn");
            }

            // TODO AJAX file to refresh only the Likes
            return RedirectToPage("/Index");
        }
    }
}