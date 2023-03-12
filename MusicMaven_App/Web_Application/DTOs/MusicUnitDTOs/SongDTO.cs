using Business_Logic.Enums;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class SongDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; } 
        public string Duration { get; set; }
        public ArtistDTO Artist { get; set; }
        public double AvrgRating { get; set; }
        public List<ReviewDTO>? Reviews { get; set; }
    }

}
