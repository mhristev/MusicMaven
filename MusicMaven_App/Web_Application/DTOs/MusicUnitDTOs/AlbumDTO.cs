using Business_Logic.Enums;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class AlbumDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; }
        public GENRE_TYPE Genre { get; set; }
        public List<ArtistDTO> Artists { get; set; }
        public double AvgRating { get; set; }

    }
}
