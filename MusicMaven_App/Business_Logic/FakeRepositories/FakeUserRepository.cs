using System;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;

namespace Business_Logic.FakeRepositories
{
	public class FakeUserRepository: IUserRepository
    {
        private List<User> _users = new List<User>();

		public FakeUserRepository()
		{
            UserFactory userFactory = new UserFactory();
            _users.Add(new User("1", "admin", "admin@admin.com", "admin", new List<User>(), type: USER_TYPE.ADMIN));
            _users.Add(new User("2", "JohnSmith", "JohnSmith@app.com", "password", new List<User>(), type: USER_TYPE.NORMAL));
            _users.Add(new User("3", "JaneDoe", "JaneDoe@admin.com", "password", new List<User>(), type: USER_TYPE.NORMAL));
            _users.Add(new User("4", "AlexJohnson", "AlexJohnson@admin.com", "password", new List<User>(), type: USER_TYPE.NORMAL));
        }

        public void Delete(string id)
        {
            User? userToRemove = _users.FirstOrDefault(u => u.Id == id);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
            }
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User? GetById(string id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }        public User? GetUserByEmail(string email)        {            return _users.FirstOrDefault(user => user.Email == email);        }        public void Insert(User entity)
        {
            _users.Add(entity);
        }

        public void Update(User entity)
        {
            User? user = _users.FirstOrDefault(u => u.Id == entity.Id);            if (user != null)            {                user.Username = entity.Username;                user.Email = entity.Email;                user.Password = entity.Password;                user.Type = entity.Type;                user.Following = entity.Following;            }
        }
    }
}

