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
        private MusicUnitService _musicUnitService;
        private ReviewService _reviewService;

        public List<ArtistDTO> Artists { get; private set; }
        public List<ReviewDTO> Reviews { get; private set; }
        public List<AlbumDTO> NewAlbums { get; private set; }
        public List<MusicUnitDTO> HighestRatedMusicUnits { get; private set; }

        public IndexModel(MusicUnitService musicUnitService, ReviewService reviewService)        {
            _musicUnitService = musicUnitService;
            _reviewService = reviewService;
        }


        public void OnGet()
        {
            Artists = _musicUnitService.GetArtists().Select(a => ArtistDTO.FromArtist(a)).ToList();
            Reviews = _reviewService.GetAll().Select(r => ReviewDTO.FromReview(r)).ToList();
            NewAlbums = _musicUnitService.GetNewReleasedAlbums(5).Select(a => AlbumDTO.FromAlbum(a)).ToList();
            HighestRatedMusicUnits = _musicUnitService.GetHighestRatedMusicUnits(5).Select(u => MusicUnitDTO.FromMusicUnit(u)).ToList();
        }
    }
}