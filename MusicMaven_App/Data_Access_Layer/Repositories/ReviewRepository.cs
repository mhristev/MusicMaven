using System;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;


namespace Data_Access_Layer.Repositories
{
	public class ReviewRepository:IRepository<Review>
	{
		public ReviewRepository()
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

