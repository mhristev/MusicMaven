using System;
using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeAlbumRepository: IRepository<Album>
	{
		public FakeAlbumRepository()
		{
		}

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        public Album? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Album entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Album entity)
        {
            throw new NotImplementedException();
        }
    }
}

