using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Song : MusicUnit
    {
        private int durationInSeconds;
        private Album album;        public Song()        {        }        public Song(string id,
                    string name,
                    string image,
                    MUSIC_UNIT_TYPE type,
                    int duration,
                    Album album,
                    double avgRating) : base(id, name, image, avgRating, type)
        {
            this.Album = album;
            this.DurationInSeconds = duration;
        }

        public int DurationInSeconds { get => durationInSeconds; 
            set 
            { 
                if(value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDurationInSeconds);
                } 
                else
                {
                    durationInSeconds = value;
                }
            } 
        }
        public Album Album { get => album; set => album = value; }

        public string DurationInMinutesAndSeconds { 
            get 
            {
                TimeSpan duration = TimeSpan.FromSeconds(durationInSeconds);
                return duration.ToString("mm\\:ss");
            }

            set
            {
                TimeSpan duration = TimeSpan.ParseExact(value, "mm\\:ss", CultureInfo.InvariantCulture);
                DurationInSeconds = (int)duration.TotalSeconds;
            }

        }
    }

}
