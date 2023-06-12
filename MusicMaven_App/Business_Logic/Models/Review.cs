using Business_Logic.Models.MusicUnits;
using System.Collections.ObjectModel;

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
        private List<User> likedBy = new List<User>();

        public Review() { }

        public Review(string id,
                      string title,
                      string content,
                      DateTime creationDate,
                      double rating,
                      MusicUnit musicUnit,
                      User creator,
                      List<User> likedBy)
        {
            this.Id = id;
            this.Title = title;
            this.Description = content;
            this.CreationDate = creationDate;
            this.Rating = rating;
            this.MusicUnit = musicUnit;
            this.Creator = creator;
            this.LikedBy = likedBy.AsReadOnly();
        }



        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidId);
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Title
        {
            get => title; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTitle);
                }
                else
                {
                    title = value;
                }
            }
        }
        public string Description
        {
            get => description; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDescription);
                }
                else
                {
                    description = value;
                }
            }
        }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public double Rating 
        { 
            get => rating; 
            set 
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRating);
                }
                rating = value; 
            } 
        }

        public MusicUnit MusicUnit { get => musicUnit; set => musicUnit = value; }
        public User Creator { get => creator; set => creator = value; }

        public ReadOnlyCollection<User> LikedBy 
        { 
            get => likedBy.AsReadOnly(); 
            set => likedBy = new List<User>(value); 
        }


        public bool Equals(Review other)
        {
            if (other == null)
            {
                return false;
            }

            // Compare the relevant properties for equality
            return Id == other.Id && Description == other.Description && Rating == other.Rating;
        }
    }
}
