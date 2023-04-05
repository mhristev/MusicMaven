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
        private static UserService instance;
        private UserFactory userFactory;
       // private List<User> users = new List<User>();
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> repository)
        {
            userFactory = new UserFactory();
            //users.Add(userFactory.CreateUser("admin", "admin@admin.com", "admin", type:USER_TYPE.ADMIN));
            //users.Add(userFactory.CreateUser("testUser1", "testUser1@user.com", "user1"));
            //users.Add(userFactory.CreateUser("testUser2", "testUser2@user.com", "user2"));
            //users.Add(userFactory.CreateUser("testUser3", "testUser3@user.com", "user3"));
            userRepository = repository;
        }



        //public static UserService Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (typeof(UserService))
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new UserService();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}

        public User GetCurrentUser()
        {
            return userRepository.GetAll().First();

        }

        public User? GetUserById(string id)
        {
            return userRepository.GetById(id);
          //  return users.Where(user => user.Id == id).FirstOrDefault();
        }

        public void CreateUser(string email, string username, string password) 
        {
            if (userRepository != null)
            userRepository.Insert(userFactory.CreateUser(username, email, password, USER_TYPE.NORMAL));
            
            //if (users.Any(user => user.Email == email))
            //{
            //    throw new ArgumentException("Email already exist");
            //}

            //if (users.Any(user => user.Username == username))
            //{
            //    throw new ArgumentException("Username already exist");
            //}
            //// TODO hash password
            //users.Add(userFactory.CreateUser(username, email, password, USER_TYPE.NORMAL));
        }

        public User? GetUserByEmail(string email)
        {
           
            return userRepository.GetAll().FirstOrDefault(u => u.Email == email);
        }
    }
}
