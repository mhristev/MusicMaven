using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Album : MusicUnit
    {
        private GENRE_TYPE genre;
        private List<Artist> artists = new List<Artist>();
        private DateTime releaseDate;        public Album()        {        }        public Album(string id,
                     string name,
                     string image,
                     MUSIC_UNIT_TYPE type,
                     GENRE_TYPE genre,
                     List<Artist> artists,
                     double avgRating,
                     DateTime releaseDate) : base(id, name, image, avgRating, type)
        {
            this.Genre = genre;
            this.Artists = artists.AsReadOnly();
            this.ReleaseDate = releaseDate;

        }

        public GENRE_TYPE Genre { get => genre; 
            set 
            {
                if (!Enum.IsDefined(typeof(GENRE_TYPE), value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGenreType);
                }
                else
                {
                    this.genre = value;
                }
            }
        }
        public ReadOnlyCollection<Artist> Artists 
        { 
            get => artists.AsReadOnly(); 
            set 
            {
                List<Artist> list = new List<Artist>(value);

                if (list.Count == 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfArtistsInAlbum);
                }

                if (list.Select(a => a.Id).Distinct().Count() != list.Count)
                {
                    throw new ArgumentException(ExceptionMessages.DuplicateArtistsInAlbum);
                }
                artists = new List<Artist>(value); 
            } 
        }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }

        public override string? ToString()
        {
            return this.Name;
        }
    }
}
