﻿    using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class Artist : MusicUnit
    {
        private ARTIST_TYPE artistType;        public Artist()        {        }        public Artist(string id,
                      string name,
                      string image,
                      MUSIC_UNIT_TYPE type,
                      ARTIST_TYPE artistType,
                      double avgRating) : base(id, name, image, avgRating, type)
        {
            this.ArtistType = artistType;
        }

        public ARTIST_TYPE ArtistType { get => artistType; 
            set
            {
                if (!Enum.IsDefined(typeof(ARTIST_TYPE), value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidArtistType);
                }
                else
                {
                    this.artistType = value;
                }
            }
        }

        public override string? ToString()
        {
            return this.Name;
        }
    }
}
