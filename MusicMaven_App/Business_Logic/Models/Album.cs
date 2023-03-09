using Business_Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Album : MusicUnit
    {
        private GENRE_TYPE genre;
        private Artist artist;
        private List<Song> songs;

        public Album(int id, string name, string image, GENRE_TYPE genre, Artist artist, List<Song> songs) : base(id, name, image)
        {
            this.genre = genre;
            this.artist = artist;
            this.songs = songs;
        }

        public GENRE_TYPE Genre { get => genre; private set => genre = value; }
        public Artist Artist { get => artist; private set => artist = value; }
        public List<Song> Songs { get => songs; private set => songs = value; }
    }
}
