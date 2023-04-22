using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class SongDTO : MusicUnitDTO
    {
        public int DurationInSeconds { get; set; }
        public AlbumDTO Album { get; set; }

        public static SongDTO FromSong(Song s)
        {
            return new SongDTO()
            {
                Id = s.Id,
                Name = s.Name,
                Image = s.Image,
                Type = s.Type,
                DurationInSeconds = s.DurationInSeconds,
                Album = AlbumDTO.FromAlbum(s.Album),
                AvrgRating = s.AvrgRating
            };
        }


    }

}
