using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Song : MusicUnit
    {
        private string duration;
        private Artist artist;

        public Song(string id,
                    string name,
                    string image,
                    string duration,
                    Artist artist,
                    double avgRating,
                    List<Review> reviews) : base(id, name, image, avgRating, reviews)
        {
            this.artist = artist;
            this.duration = duration;
        }

        public string Duration { get => duration; private set => duration = value; }
        public Artist Artist { get => artist; private set => artist = value; }
    }

}
