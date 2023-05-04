using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business_Logic.Interfaces.IServices;
using Web_Application.DTOs.MusicUnitDTOs;
using Web_Application.DTOs;
using Web_Application.Helpers;using Business_Logic.Enums;namespace Web_Application.Pages
{
	public class SearchModel : PageModel
    {
        private IMusicUnitService musicUnitService;
        private IUserService userService;        public List<MusicUnitDTO> musicUnits { get; set; }        public List<UserDTO> users { get; set; }        public SearchModel(IMusicUnitService musicUnitService, IUserService userService)        {            this.musicUnitService = musicUnitService;            this.userService = userService;        }        public IActionResult OnGet(string? searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {                musicUnits = musicUnitService.FindMusicUnitsByKeywordOrderedByHighestRated(searchString.ToLower())                    .Select(u => MusicUnitDTO.FromMusicUnit(u))                    .ToList();                users = userService.FindUsersByKeywordInUsername(searchString.ToLower())                    .Select(u => UserDTO.FromUser(u))                    .ToList();                return Page();            }
            else            {
                return Redirect(PageRoutes.Index);
            }
        }
        public IActionResult OnGetMusicUnitInfo(string id, MUSIC_UNIT_TYPE unitTyoe)        {
            switch (unitTyoe)
            {                case MUSIC_UNIT_TYPE.ALBUM:                    // Redirect to the Album page                    return RedirectToPage(PageRoutes.SingleAlbum, new { id = id });                case MUSIC_UNIT_TYPE.SONG:                    // Redirect to the Song page                    return RedirectToPage(PageRoutes.SingleSong, new { id = id });                case MUSIC_UNIT_TYPE.ARTIST:                    // Redirect to the Artist page                    return RedirectToPage(PageRoutes.SingleArtist, new { id = id });                default:                    // Redirect to the home page                    return RedirectToPage(PageRoutes.Index);
            }

        }

    }
}
