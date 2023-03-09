using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
        public class Song : MusicUnit
        {
            private string duration;
            private Artist artist;

            public Song(int id, string name, string image, string duration, Artist artist) : base(id, name, image)
            {
                this.artist = artist;
                this.duration = duration;
            }

            public string Duration { get => duration; private set => duration = value; }
            public Artist Artist { get => artist; private set => artist = value; }
        }
}
