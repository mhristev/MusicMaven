using System;
using Business_Logic.Interfaces;
using Business_Logic.Models;

namespace Business_Logic.FakeRepositories
{
	public class FakeReviewRepository:IRepository<Review>
	{
		public FakeReviewRepository()
		{
		}

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll()
        {
            throw new NotImplementedException();
        }

        public Review? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}

