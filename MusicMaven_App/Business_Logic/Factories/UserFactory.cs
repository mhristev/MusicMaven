﻿using Business_Logic.Models;
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
        public static User CreateUser(string username, string email, string password, string image, USER_TYPE type = USER_TYPE.NORMAL)
        {
            if (string.IsNullOrEmpty(password))            {
                throw new ArgumentException(ExceptionMessages.InvalidPassword);
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return new User(Guid.NewGuid().ToString(), username, email, hashedPassword, new List<User>(), new List<User>(), type, image);
        }
    }
}
