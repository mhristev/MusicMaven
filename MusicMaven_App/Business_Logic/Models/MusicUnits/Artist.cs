using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Artist : MusicUnit
    {
        private ARTIST_TYPE artistType;
        private List<Album> albums;

        public Artist(string id,
                      string name,
                      string image,
                      ARTIST_TYPE artistType,
                      List<Album> albums,
                      double avgRating,
                      List<Review> reviews) : base(id, name, image, avgRating, reviews)
        {
            this.artistType = artistType;
            this.albums = albums;
        }

        public ARTIST_TYPE ArtistType { get => artistType; private set => artistType = value; }
        public List<Album> Albums { get => albums; private set => albums = value; }
    }
}
