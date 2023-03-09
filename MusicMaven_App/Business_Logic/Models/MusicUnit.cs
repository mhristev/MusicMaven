using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class MusicUnit
    {
        private int id;
        private string name;
        private string image;

        public MusicUnit(int id, string name, string image)
        {
            this.id = id;
            this.name = name;
            this.image = image;
        }

        public int Id { get => id; private set => id = value; }
        public string Name { get => name; private set => name = value; }
        public string Image { get => image; private set => image = value; }
    }
}
