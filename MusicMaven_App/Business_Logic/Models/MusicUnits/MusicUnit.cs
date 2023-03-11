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
        private int id;
        private string name;
        private string image;
        private double avgRating;
        private MUSIC_UNIT_TYPE type;
        private List<Review> reviews = new List<Review>();

        public MusicUnit(int id, string name, string image, double avrgRating, List<Review> reviews)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.avgRating = avrgRating;
            Reviews = reviews;
        }

        public int Id { get => id; private set => id = value; }
        public string Name { get => name; private set => name = value; }
        public string Image { get => image; private set => image = value; }
        public double AvrgRating { get => avgRating; private set => avgRating = value; }
        public MUSIC_UNIT_TYPE Type { get => type; private set => type = value; }
        public List<Review> Reviews { get => reviews; private set => reviews = value; }
    }
}
