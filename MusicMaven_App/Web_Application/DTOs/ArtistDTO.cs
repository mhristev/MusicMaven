using Business_Logic.Enums;

namespace Web_Application.DTOs
{
    public class ArtistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ARTIST_TYPE Type { get; set; }
        public List<AlbumDTO> Albums { get; set; }
    }
}
