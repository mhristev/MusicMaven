using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class User
    {
        private string id;
        private string username;
        private string email;
        private string password;
        private List<User> following;
        private USER_TYPE type;

        public User(string id, string username, string email, string password, List<User> following, USER_TYPE type)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.following = following;
            this.type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username;  set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public List<User> Following { get => following; set => following = value; }

        public USER_TYPE Type { get => type; set => type = value; }
    }
}
