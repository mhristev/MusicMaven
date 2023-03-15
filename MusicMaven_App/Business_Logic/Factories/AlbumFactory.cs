using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public class AlbumFactory
    {
        public Album CreateAlbum(string name, string image, double avgRating, MUSIC_UNIT_TYPE type, GENRE_TYPE genre, List<Artist> albumCreators)
        {
            return new Album(Guid.NewGuid().ToString(), name, image, type, genre, albumCreators, avgRating);
        }
    }
}
