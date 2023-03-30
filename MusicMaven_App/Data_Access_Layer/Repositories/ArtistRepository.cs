using System;
using Business_Logic.Models.MusicUnits;

namespace Data_Access_Layer.Repositories
{
	public class ArtistRepository: IRepository<Artist>
	{
		public ArtistRepository()
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

