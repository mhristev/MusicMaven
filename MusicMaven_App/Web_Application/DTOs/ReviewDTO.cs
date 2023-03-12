using System.ComponentModel.DataAnnotations;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.DTOs
{
    public class ReviewDTO
    {
        public string? Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Content { get; set; }
        public DateTime? CreationDate { get; set; }
        
        [Required]
        public double Rating { get; set; }
        public MusicUnitDTO? MusicUnit { get; set; }
        public UserDTO? Creator { get; set; }
        public List<UserDTO>? LikedBy { get; set; }
    }

}
