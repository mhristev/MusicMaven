namespace Web_Application.DTOs
{
    public class SongDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Duration { get; set; }
        public ArtistDTO Artist { get; set; }
    }

}
