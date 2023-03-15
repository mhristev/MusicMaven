using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Song : MusicUnit
    {
        private int durationInSeconds;
        private Album album;

        public Song(string id,
                    string name,
                    string image,
                    MUSIC_UNIT_TYPE type,
                    int duration,
                    Album album,
                    double avgRating) : base(id, name, image, avgRating, type)
        {
            this.album = album;
            this.durationInSeconds = duration;
        }

        public int DurationInSeconds { get => durationInSeconds; private set => durationInSeconds = value; }
        public Album Album { get => album; private set => album = value; }
    }

}
