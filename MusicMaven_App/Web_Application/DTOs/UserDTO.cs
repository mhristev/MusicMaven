namespace Web_Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<UserDTO> Following { get; set; }
    }

}
