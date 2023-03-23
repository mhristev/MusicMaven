using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages
{
    public class IndexModel : PageModel
    {

        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        private ReviewService reviewService = ReviewService.Instance;
        public List<ArtistDTO> Artists { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        public List<AlbumDTO> NewAlbums { get; private set; }

        public void OnGet()
        {
            Artists = musicUnitService.GetArtists().Select(a => ArtistDTO.FromArtist(a)).ToList();
            Reviews = reviewService.GetAll().Select(r => ReviewDTO.FromReview(r)).ToList();
            NewAlbums = musicUnitService.GetNewReleases().Select(a => AlbumDTO.FromAlbum(a)).ToList();
        }

       
        public void OnPostLike(string reviewId)
        {
            reviewService.AddLikeToReviewFromCurrentUser(reviewId, "userId");
            // TODO AJAX file to refresh only the Likes
            OnGet();
        }
    }
}