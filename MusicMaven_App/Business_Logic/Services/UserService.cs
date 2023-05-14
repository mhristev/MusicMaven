using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.Exceptions;
using Business_Logic.Interfaces.IServices;

namespace Business_Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public User? GetUserById(string id)
        {
            return _userRepository.GetById(id);
        }
        public void CreateUser(User user)
        {
            _userRepository.Insert(user);
        }

        public User? GetUserByEmail(string email)
        {            if (string.IsNullOrEmpty(email))            {                throw new EmptyEmailException();            }            if (!EmailFormatter.IsValid(email))            {                throw new InvalidEmailException(email);            }            return _userRepository.GetUserByEmail(email);
        }        public List<User> FindUsersByKeywordInUsername(string keyword)        {            return _userRepository.FindUsersByKeywordInUsername(keyword);        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
    }
}
