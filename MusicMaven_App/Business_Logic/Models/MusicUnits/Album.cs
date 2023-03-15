using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Album : MusicUnit
    {
        private GENRE_TYPE genre;
        private List<Artist> artists;  

        public Album(string id,
                     string name,
                     string image,
                     MUSIC_UNIT_TYPE type,
                     GENRE_TYPE genre,
                     List<Artist> artists,
                     double avgRating) : base(id, name, image, avgRating, type)
        {
            this.genre = genre;
            this.artists = artists;

        }

        public GENRE_TYPE Genre { get => genre; private set => genre = value; }
        public List<Artist> Artist { get => artists; private set => artists = value; }

    }
}
