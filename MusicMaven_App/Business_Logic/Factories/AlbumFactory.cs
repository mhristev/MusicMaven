using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public static class AlbumFactory
    {
        public static Album CreateAlbum(string name, string image, MUSIC_UNIT_TYPE type, GENRE_TYPE genre, List<Artist> albumCreators, DateTime releaseDate)
        {
            return new Album(Guid.NewGuid().ToString(), name, image, type, genre, albumCreators, 0, releaseDate);
        }
    }
}
