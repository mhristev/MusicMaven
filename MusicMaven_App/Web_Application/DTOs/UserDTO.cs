using Business_Logic.Factories;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<UserDTO> Following { get; set; }

        public static UserDTO FromUser(User user)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.Username = user.Username;
            userDTO.Email = user.Email;
            userDTO.Following = user.Following.Select(u => UserDTO.FromUser(u)).ToList(); 
            return userDTO;
        }

    }

}
