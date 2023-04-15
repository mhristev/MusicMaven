﻿using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.Exceptions;

namespace Business_Logic.Services
{
    public class UserService
    {
        private UserFactory userFactory;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            userFactory = new UserFactory();
            _userRepository = repository;
        }

        public User? GetUserById(string id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(string email, string username, string password) 
        {
            _userRepository.Insert(userFactory.CreateUser(username, email, password, USER_TYPE.NORMAL));
        }

        public User? GetUserByEmail(string email)
        {            if (string.IsNullOrEmpty(email))            {                throw new EmptyEmailException();            }            if (!EmailFormatter.IsValid(email))            {                throw new InvalidEmailException(email);            }            return _userRepository.GetUserByEmail(email);
        }
    }
}
