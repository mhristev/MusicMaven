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
        private MUSIC_UNIT_TYPE type;        public MusicUnit() { }        public MusicUnit(string id, string name, string image, double avrgRating, MUSIC_UNIT_TYPE type)
        {
            this.Id = id;
            this.Name = name;
            this.Image = image;
            this.AvrgRating = avrgRating;
            this.Type = type;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter a valid name.");
                }
                else
                {
                    name = value;
                }
            } 
        }
        public string Image { get => image; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Enter a valid URL");
                }
                else
                {
                    image = value;
                }
            }
        }
        public double AvrgRating
        {
            get => avgRating;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Enter a valid Rating");
                }
                else
                {
                    avgRating = value;
                }
            }
        }
        public MUSIC_UNIT_TYPE Type { get => type; 
            set
            {
                if (!Enum.IsDefined(typeof(MUSIC_UNIT_TYPE), value))
                {
                    throw new ArgumentException("Enter a valid music unit type.");
                }
                else
                {
                    this.type = value;
                }
            }
        }
    }
}
