using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Services
{
    public class UserService
    {
        private UserFactory userFactory;
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> repository)
        {
            userFactory = new UserFactory();
            userRepository = repository;
        }

        public User GetCurrentUser()
        {
            return userRepository.GetAll().First();

        }

        public User? GetUserById(string id)
        {
            return userRepository.GetById(id);
        }

        public void CreateUser(string email, string username, string password) 
        {
            userRepository.Insert(userFactory.CreateUser(username, email, password, USER_TYPE.NORMAL));
        }

        public User? GetUserByEmail(string email)
        {
           
            return userRepository.GetAll().FirstOrDefault(u => u.Email == email);
        }
    }
}
