using Business_Logic.Enums;

namespace Web_Application.DTOs
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public GENRE_TYPE Genre { get; set; }
        public ArtistDTO Artist { get; set; }
        public List<SongDTO> Songs { get; set; }
    }
}
