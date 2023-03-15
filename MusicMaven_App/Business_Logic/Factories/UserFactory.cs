using Business_Logic.Models;
using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public  class UserFactory
    {
        public User CreateUser(string username, string email, string password)
        {
            return new User(Guid.NewGuid().ToString(), email, username, password, new List<User>(), USER_TYPE.NORMAL);
        }
    }
}
