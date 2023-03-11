using Business_Logic.Enums;

namespace Web_Application.DTOs.MusicUnitDTOs
{
    public class MusicUnitDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public MUSIC_UNIT_TYPE Type { get; set; } // "Album", "Song", or "Artist"
        public List<ReviewDTO>? Reviews { get; set; }

        // properties specific to AlbumDTO
        public GENRE_TYPE? Genre { get; set; }
        public List<SongDTO> Songs { get; set; }

        // properties specific to SongDTO
        public string Duration { get; set; }
        public ArtistDTO Artist { get; set; }

        // properties specific to ArtistDTO
        public ARTIST_TYPE? ArtistType { get; set; }
        public List<AlbumDTO> Albums { get; set; }
    }
}
