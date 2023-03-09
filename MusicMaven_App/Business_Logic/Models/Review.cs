using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Review
    {
        private int id;
        private string content;
        private DateTime creationDate;
        private double rating;
        private MusicUnit musicUnit;
        private User creator;
        private List<Like> likes;

        public Review(int id, string content, DateTime creationDate, double rating, MusicUnit musicUnit, User creator, List<Like> likes)
        {
            this.id = id;
            this.content = content;
            this.creationDate = creationDate;
            this.rating = rating;
            this.musicUnit = musicUnit;
            this.creator = creator;
            this.likes = likes;
        }

        public int Id { get => id; private set => id = value; }
        public string Content { get => content; private set => content = value; }
        public DateTime CreationDate { get => creationDate; private set => creationDate = value; }
        public double Rating { get => rating; private set => rating = value; }

        public MusicUnit MusicUnit { get => musicUnit; private set => musicUnit = value; }
        public User Creator { get => creator; private set => creator = value; }

        public List<Like> Likes { get => likes; private set => likes = value; }
    }
}
