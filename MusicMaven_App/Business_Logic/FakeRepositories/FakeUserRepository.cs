using System;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Exceptions;

namespace Business_Logic.FakeRepositories
{
	public class FakeUserRepository: IUserRepository
    {
        private List<User> _users = new List<User>();

		public FakeUserRepository()
		{
            _users.Add(new User("1", "admin", "admin@admin.com", BCrypt.Net.BCrypt.HashPassword("admin"), new List<User>(), new List<User>(), type: USER_TYPE.ADMIN, "image"));
            _users.Add(new User("2", "JohnSmith", "JohnSmith@app.com", BCrypt.Net.BCrypt.HashPassword("password"), new List<User>(), new List<User>(), type: USER_TYPE.NORMAL, "image"));
            _users.Add(new User("3", "JaneDoe", "JaneDoe@admin.com", BCrypt.Net.BCrypt.HashPassword("password"), new List<User>(), new List<User>(), type: USER_TYPE.NORMAL, "image"));
            _users.Add(new User("4", "AlexJohnson", "AlexJohnson@admin.com", BCrypt.Net.BCrypt.HashPassword("password"), new List<User>(), new List<User>(), type: USER_TYPE.NORMAL, "image"));
        }

        public void Delete(string id)
        {
            User? userToRemove = _users.FirstOrDefault(u => u.Id == id);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
            }
        }        public List<User> FindUsersByKeywordInUsername(string keyword)        {            return _users.Where(a => a.Username.ToLower().Contains(keyword.ToLower()))                .ToList();        }        public List<User> GetAll()
        {
            return _users;
        }

        public User? GetById(string id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        public List<User> GetLikedByUsersForReviewId(string reviewId)
        {
            throw new NotImplementedException();
        }

        public User? GetUserByEmail(string email)        {            return _users.FirstOrDefault(user => user.Email == email);        }        public void Insert(User entity)
        {            if (_users.Any(u => u.Email == entity.Email))            {                throw new EmailExistException(entity.Email);            }            if (_users.Any(u => u.Username == entity.Username))            {                throw new UsernameExistException(entity.Username);            }            _users.Add(entity);
        }

        public void Update(User entity)
        {
            User? user = _users.FirstOrDefault(u => u.Id == entity.Id);            if (user != null)            {                user.Username = entity.Username;                user.Email = entity.Email;                user.Password = entity.Password;                user.Type = entity.Type;                user.Following = entity.Following;            }
        }
    }
}

