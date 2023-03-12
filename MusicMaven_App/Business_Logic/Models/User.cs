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

        public User(string id, string username, string email, string password, List<User> following)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.following = following;
        }

        public string Id { get => id; private set => id = value; }
        public string Username { get => username; private set => username = value; }
        public string Email { get => email; private set => email = value; }
        public string Password { get => password; private set => password = value; }

        public List<User> Following { get => following; private set => following = value; }
    }
}
