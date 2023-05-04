using Business_Logic.Models;
using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Business_Logic.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string username, string email, string password, USER_TYPE type = USER_TYPE.NORMAL)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return new User(Guid.NewGuid().ToString(), username, email, hashedPassword, new List<User>(), new List<User>(), type);
        }
    }
}
