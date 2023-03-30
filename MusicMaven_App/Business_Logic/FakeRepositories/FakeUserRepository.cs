using System;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;

namespace Business_Logic.FakeRepositories
{
	public class FakeUserRepository: IRepository<User>
    {
        private List<User> _users = new List<User>();

		public FakeUserRepository()
		{
            UserFactory userFactory = new UserFactory();
            _users.Add(userFactory.CreateUser("admin", "admin@admin.com", "admin", type: USER_TYPE.ADMIN));
            _users.Add(userFactory.CreateUser("testUser1", "testUser1@user.com", "user1"));
            _users.Add(userFactory.CreateUser("testUser2", "testUser2@user.com", "user2"));
            _users.Add(userFactory.CreateUser("testUser3", "testUser3@user.com", "user3"));
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
        }

        public void Insert(User entity)
        {
            _users.Add(entity);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

