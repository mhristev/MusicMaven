using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages
{
    public class IndexModel : PageModel
    {
        private MusicUnitService musicUnitService = MusicUnitService.Instance;

        [BindProperty]
        public List<MusicUnitDTO> MusicUnits { get; private set; }
        

        public void OnGet()
        {
           MusicUnits = musicUnitService.GetAllMusicUnits().Select(m => MusicUnitDTO.FromMusicUnit(m)).ToList();

        }
    }
}