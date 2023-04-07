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
        private ReviewService _reviewService;
        private MusicUnitService _musicUnitService;

        public ArtistDTO Artist { get; private set; }
        public List<AlbumDTO> Albums { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        public List<SongDTO> Songs { get; private set; }

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }

        public SingleArtist(ReviewService reviewService, MusicUnitService musicUnitService)        {
            this._reviewService = reviewService;
            this._musicUnitService = musicUnitService;
        }

        public void OnGet(string id)
        {

            Artist? artist = (Artist?)_musicUnitService.GetMusicUnitWithId(id);
            if (artist != null)
            {
                Artist = ArtistDTO.FromArtist(artist);
                Albums = _musicUnitService.GetAlbumsForArtist(artist).Select(album => AlbumDTO.FromAlbum(album)).ToList();
                MusicUnit? musicUnit = _musicUnitService.GetMusicUnitWithId(id);
                if (musicUnit != null)
                {
                    Reviews = _reviewService.GetReviewsForMusicUnit(musicUnit).Select(review => ReviewDTO.FromReview(review)).ToList();
                }
                Songs = _musicUnitService.GetHighestRatedSongsForArtist(artist, 5).Select(song => SongDTO.FromSong(song)).ToList();
            }
        }
       
    }
}
