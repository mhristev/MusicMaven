using System;
using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeArtistRepository: IRepository<Artist>
	{
		public FakeArtistRepository()
		{
		}

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Artist> GetAll()
        {
            throw new NotImplementedException();
        }

        public Artist? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Artist entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Artist entity)
        {
            throw new NotImplementedException();
        }
    }
}

