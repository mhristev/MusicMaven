using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.Exceptions;
using System.Text.RegularExpressions;using Business_Logic.Services;namespace Business_Logic.Models
{
    public class User
    {
        private string id;
        private string username;
        private string email;
        private string password;
        private List<User> following;
        private List<User> followers;
        private USER_TYPE type;

        public User(string id, string username, string email, string password, List<User> following, List<User> followers, USER_TYPE type)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Following = following;
            this.Followers = followers;
            this.Type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Username
        {
            get => username;
            set            {
                if (string.IsNullOrEmpty(value))                {
                    throw new EmptyUsernameException();
                }
                username = value;
            }

        }
        public string Email
        {
            get => email;            set            {                if (string.IsNullOrEmpty(value))                {                    throw new EmptyEmailException();                }                if (!EmailFormatter.IsValid(value))                {                    throw new InvalidEmailException(value);                }                email = value;            }        }
        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrEmpty(value))                {
                    throw new EmptyPasswordException();
                }
                password = value;
            }
        }

        public List<User> Following { get => following; set => following = value; }
        public List<User> Followers { get => followers; set => followers = value; }
        public USER_TYPE Type { get => type; set => type = value; }
    }
}
