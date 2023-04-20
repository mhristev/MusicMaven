using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Logic.Factories
{
    public static class ArtistFactory
    {
        public static Artist CreateArtist(string name, string img, double avgRating, MUSIC_UNIT_TYPE type, ARTIST_TYPE artistType)
        {
            return new Artist(Guid.NewGuid().ToString(), name, img, type, artistType, avgRating);
        }
    }
}
