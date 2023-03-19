using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models.MusicUnits
{
    public class MusicUnit
    {
        private string id;
        private string name;
        private string image;
        private double avgRating;
        private MUSIC_UNIT_TYPE type;

        public MusicUnit(string id, string name, string image, double avrgRating, MUSIC_UNIT_TYPE type)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.avgRating = avrgRating;
            this.type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; private set => name = value; }
        public string Image { get => image; private set => image = value; }
        public double AvrgRating { get => avgRating; private set => avgRating = value; }
        public MUSIC_UNIT_TYPE Type { get => type; private set => type = value; }
    }
}
