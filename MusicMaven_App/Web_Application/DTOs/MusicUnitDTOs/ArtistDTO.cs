using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class ArtistDTO : MusicUnitDTO
    {
        public ARTIST_TYPE ArtistType { get; set; }

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
