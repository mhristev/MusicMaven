using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.DTOs
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public double Rating { get; set; }
        public MusicUnitDTO MusicUnit { get; set; }
        public UserDTO Creator { get; set; }
        public List<UserDTO> LikedBy { get; set; }
    }

}
