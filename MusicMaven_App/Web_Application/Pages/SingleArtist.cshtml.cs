using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;

namespace Web_Application.Pages
{
    public class SingleArtistModel : PageModel
    {

        [BindProperty]
        public ReviewDTO ReviewDTO { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/Reviews");
            }
            return Page();
        }
    }
}
