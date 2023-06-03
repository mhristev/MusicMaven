using Business_Logic.Enums;
using Business_Logic.Interfaces;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs.MusicUnitDTOs;
{
    public class DiscoverModel : PageModel
    {
        {
            Recommendations = new Dictionary<MusicUnitDTO, string>();
            string? id = currentUserProvider.GetCurrentUserId();
            if (id != null)
            }
        }

        public IActionResult OnGetRedirectToMusicUnit(string id, MUSIC_UNIT_TYPE unitType)
            switch (unitType)
            {
            }
        }
    }
}