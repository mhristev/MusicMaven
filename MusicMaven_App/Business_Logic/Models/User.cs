using Business_Logic.Exceptions;
using Business_Logic.Models.Enums;
using Business_Logic.Services;using System.Collections.ObjectModel;

namespace Business_Logic.Models
{
    public class User
    {
        private string id;
        private string username;
        private string email;
        private string password;
        private List<User> following = new List<User>();
        private List<User> followers = new List<User>();
        private USER_TYPE type;        private string image;        public User()        {        }        public User(string id, string username, string email, string password, List<User> following, List<User> followers, USER_TYPE type, string image)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Following = following.AsReadOnly();
            this.Followers = followers.AsReadOnly();
            this.Image = image;
            this.Type = type;
        }

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidId);
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Username
        {
            get => username;
            set            {
                if (string.IsNullOrEmpty(value))                {
                    throw new ArgumentException(ExceptionMessages.InvalidUsername);
                }
                username = value;
            }

        }
        public string Email
        {
            get => email;            set            {                if (string.IsNullOrEmpty(value))                {
                    throw new ArgumentException(ExceptionMessages.InvalidEmail);                }                if (!EmailFormatter.IsValid(value))                {
                    throw new ArgumentException(ExceptionMessages.InvalidFormatEmail);                }                email = value;            }        }
        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)                {
                    throw new ArgumentException(ExceptionMessages.InvalidPassword);
                }
                password = value;
            }
        }

        public ReadOnlyCollection<User> Following { get => following.AsReadOnly(); set => following = new List<User>(value); }
        public ReadOnlyCollection<User> Followers { get => followers.AsReadOnly(); set => followers = new List<User>(value); }
        public USER_TYPE Type
        {
            get => type;
            set
            {
                if (!Enum.IsDefined(typeof(USER_TYPE), value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidUserType);
                }
                else
                {
                    type = value;
                }
            }
        }
        public string Image
        {
            get => image;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidImage);
                }
                else
                {
                    image = value;
                }
            }
        }
    }
}
