using System;
using Business_Logic.Interfaces;
using Business_Logic.Models;

namespace Data_Access_Layer.Repositories
{
	public class UserRepository: IRepository<User>
	{
		public UserRepository()
		{
		}

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

