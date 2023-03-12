using Business_Logic.Enums;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class ArtistDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; }
        public ARTIST_TYPE ArtistType { get; set; }
        public List<AlbumDTO>? Albums { get; set; }
        public double AvrgRating { get; set; }
        public List<ReviewDTO>? Reviews { get; set; }
    }
}
