using System;
using Business_Logic.Models.MusicUnits;

namespace Data_Access_Layer.Repositories
{
	public class SongRepository: IRepository<Song>
	{
		public SongRepository()
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

