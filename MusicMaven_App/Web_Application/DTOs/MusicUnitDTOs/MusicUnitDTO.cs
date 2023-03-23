using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class MusicUnitDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; } // "Album", "Song", or "Artist"

        public double AvrgRating { get; set; }

        //// properties specific to AlbumDTO
        //public GENRE_TYPE? Genre { get; set; }
        //public List<ArtistDTO> Artists { get; set; }

        //// properties specific to SongDTO
        //public int DurationInSeconds { get; set; }
        //public ArtistDTO Artist { get; set; }

        //// properties specific to ArtistDTO
        //public ARTIST_TYPE ArtistType { get; set; }

        public static MusicUnitDTO FromMusicUnit(MusicUnit unit)
        {
            return new MusicUnitDTO
            {
                Id = unit.Id,
                Name = unit.Name,
                Image = unit.Image,
                Type = unit.Type,
                AvrgRating = unit.AvrgRating
            };
        }
    }
}
