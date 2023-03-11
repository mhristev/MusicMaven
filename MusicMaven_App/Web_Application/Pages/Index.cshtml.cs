using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public List<ArtistDTO> Artists { get; private set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Artists = new List<ArtistDTO>()
            {
                new ArtistDTO()
                {
                    
                    Name = "Tyler, The Creator",
                    Image = "images/tyler.jpeg",

                },
                new ArtistDTO()
                {
                    Name = "Tyler, The Creator",
                    Image = "images/tyler.jpeg"
                },
                new ArtistDTO()
                {
                    Name = "Tyler, The Creator",
                    Image = "images/tyler.jpeg"
                },
                new ArtistDTO()
                {
                    Name = "Tyler, The Creator",
                    Image = "images/tyler.jpeg"
                }

            };
            

        }
    }
}