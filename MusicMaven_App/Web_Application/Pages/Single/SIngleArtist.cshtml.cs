using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages
{
    public class SingleArtist : PageModel
    {
        private ReviewService reviewService = ReviewService.Instance;
        private MusicUnitService musicUnitService = MusicUnitService.Instance;
        public ArtistDTO Artist { get; private set; }
        public List<AlbumDTO> Albums { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }
        public void OnGet(string id)
        {
            try
            {
                Artist? artist = (Artist?)musicUnitService.GetMusicUnitWithId(id);
                if (artist != null)
                {
                    Artist = ArtistDTO.FromArtist(artist);
                    Albums = musicUnitService.GetAlbumsForArtistId(id).Select(album => AlbumDTO.FromAlbum(album)).ToList();
                    Reviews = reviewService.GetReviewsForMusicUnit(id).Select(review => ReviewDTO.FromReview(review)).ToList();
                }

            } catch (ArgumentException ex)
            {
                
            }

        }
        public void OnPost(string id)
        {
            if (ModelState.IsValid)
            {
                reviewService.AddReview(ReviewDTO.Title, ReviewDTO.Description, ReviewDTO.Rating, id, "creatorId");
            }
            OnGet(id);
        }

        public void OnPostLike(string reviewId, string artistId)
        {
            reviewService.AddLikeToReviewFromCurrentUser(reviewId, "userId");
            // TODO AJAX file to refresh only the Likes
            OnGet(artistId);
        }
    }
}
