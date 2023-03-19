using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class ArtistDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; }
        public ARTIST_TYPE ArtistType { get; set; }
        public double AvrgRating { get; set; }

        public static ArtistDTO FromArtist(Artist a) {
            return new ArtistDTO()
            {
                Id = a.Id,
                Name = a.Name,
                Image = a.Image,
                Type = a.Type,
                ArtistType = a.ArtistType,
                AvrgRating = a.AvrgRating
            };
        }
    }
}
