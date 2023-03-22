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
        public User CreateUser(string username, string email, string password, USER_TYPE type = USER_TYPE.NORMAL)
        {
            return new User(Guid.NewGuid().ToString(), username, email, password, new List<User>(), type);
        }
    }
}
