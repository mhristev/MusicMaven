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
        public List<SongDTO> Songs { get; private set; }


        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }
        public void OnGet(string id)
        {

            Artist? artist = (Artist?)musicUnitService.GetMusicUnitWithId(id);
            if (artist != null)
            {
                Artist = ArtistDTO.FromArtist(artist);
                Albums = musicUnitService.GetAlbumsForArtist(artist).Select(album => AlbumDTO.FromAlbum(album)).ToList();
                MusicUnit? musicUnit = musicUnitService.GetMusicUnitWithId(id);
                if (musicUnit != null)
                {
                    Reviews = reviewService.GetReviewsForMusicUnit(musicUnit).Select(review => ReviewDTO.FromReview(review)).ToList();
                }
                Songs = musicUnitService.GetMostPopularSongsForArtist(artist).Select(song => SongDTO.FromSong(song)).ToList();
            }
        }
       
    }
}
