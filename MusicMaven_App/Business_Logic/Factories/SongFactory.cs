using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public class SongFactory
    {
        public Song CreateSong(string name, string img, double avgRating, MUSIC_UNIT_TYPE type, int durationInSeconds, Album songAlbum)
        {
            return new Song(Guid.NewGuid().ToString(), name, img, type, durationInSeconds, songAlbum, avgRating);
        } 
    }
}
