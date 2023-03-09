namespace Web_Application.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string Rating { get; set; }
        public MusicUnitDTO MusicUnit { get; set; }
        public UserDTO Creator { get; set; }
        public List<LikeDTO> Likes { get; set; }
    }

}
