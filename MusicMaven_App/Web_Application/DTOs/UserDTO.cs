using Business_Logic.Models;
using System.ComponentModel.DataAnnotations;

namespace Web_Application.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "The Username field is required.")]        [StringLength(50, ErrorMessage = "The Username field must be a maximum of 50 characters.")]
        public string Username { get; set; }        [Required(ErrorMessage = "The Email field is required.")]        [EmailAddress(ErrorMessage = "Invalid Email address.")]
        public string Email { get; set; }


        public List<UserDTO> Following { get; set; }

        public List<UserDTO> Followers { get; set; }

        public string Image { get; set; }

        public static UserDTO FromUser(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.Username = user.Username;
            userDTO.Email = user.Email;
            userDTO.Following = user.Following.Select(u => UserDTO.FromUser(u)).ToList();
            userDTO.Followers = user.Followers.Select(u => UserDTO.FromUser(u)).ToList();
            userDTO.Image = user.Image;
            return userDTO;
        }

    }

}
