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
        private DateTime releaseDate;        public Album()        {        }        public Album(string id,
                     string name,
                     string image,
                     MUSIC_UNIT_TYPE type,
                     GENRE_TYPE genre,
                     List<Artist> artists,
                     double avgRating,
                     DateTime releaseDate) : base(id, name, image, avgRating, type)
        {
            this.genre = genre;
            this.artists = artists;
            this.releaseDate = releaseDate;

        }

        public GENRE_TYPE Genre { get => genre; 
            set 
            {
                if (!Enum.IsDefined(typeof(GENRE_TYPE), value))
                {
                    throw new ArgumentException("Enter a valid genre type.");
                }
                else
                {
                    this.genre = value;
                }
            }
        }
        public List<Artist> Artists { get => artists; set => artists = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }

        public override string? ToString()
        {
            return this.Name;
        }
    }
}
