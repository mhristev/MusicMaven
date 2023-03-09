using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Artist : MusicUnit
    {
        private ARTIST_TYPE type;
        private List<Album> albums;

        public Artist(int id, string name, string image, ARTIST_TYPE type, List<Album> albums) : base(id, name, image)
        {
            this.type = type;
            this.albums = albums;
        }

        public ARTIST_TYPE Type { get => type; private set => type = value; }
        public List<Album> Albums { get => albums; private set => albums = value; }
    }
}
