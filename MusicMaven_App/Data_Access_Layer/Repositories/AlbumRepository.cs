using System;
using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;

namespace Data_Access_Layer.Repositories
{
	public class AlbumRepository: IRepository<Album>
	{
		public AlbumRepository()
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

