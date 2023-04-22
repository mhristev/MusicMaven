using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class AlbumDTO : MusicUnitDTO
    {
        public GENRE_TYPE Genre { get; set; }
        public List<ArtistDTO> Artists { get; set; }
        public DateTime ReleaseDAte { get; set; }

        public static AlbumDTO FromAlbum(Album a)
        {
            return new AlbumDTO()
            {
                Id = a.Id,
                Name = a.Name,
                Image = a.Image,
                Type = a.Type,
                Genre = a.Genre,
                AvrgRating = a.AvrgRating,
                ReleaseDAte = a.ReleaseDate,
                Artists = a.Artists.Select(artist => ArtistDTO.FromArtist(artist)).ToList()
            };
        }

    }
}
