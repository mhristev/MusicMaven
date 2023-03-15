using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.Models
{
    public class Review
    {
        private string id;
        private string title;
        private string description;
        private DateTime creationDate;
        private double rating;
        private MusicUnit musicUnit;
        private User creator;
        private List<User> likedBy;

        public Review(string id,
                      string title,
                      string content,
                      DateTime creationDate,
                      double rating,
                      MusicUnit musicUnit,
                      User creator,
                      List<User> likedBy)
        {
            this.id = id;
            this.title = title;
            this.description = content;
            this.creationDate = creationDate;
            this.rating = rating;
            this.musicUnit = musicUnit;
            this.creator = creator;
            this.likedBy = likedBy;
        }



        public string Id { get => id; private set => id = value; }
        public string Title { get => title; private set => title = value; }
        public string Description { get => description; private set => description = value; }
        public DateTime CreationDate { get => creationDate; private set => creationDate = value; }
        public double Rating { get => rating; private set => rating = value; }

        public MusicUnit MusicUnit { get => musicUnit; private set => musicUnit = value; }
        public User Creator { get => creator; private set => creator = value; }

        public List<User> LikedBy { get => likedBy; private set => likedBy = value; }
    }
}
