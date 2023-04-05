using System;
using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.FakeRepositories
{
	public class FakeSongRepository: IRepository<Song>
	{
		public FakeSongRepository()
		{
		}

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
         
        public List<Song> GetAll()
        {
            throw new NotImplementedException();
        }

        public Song? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Song entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Song entity)
        {
            throw new NotImplementedException();
        }
    }
}

