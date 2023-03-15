using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public class ReviewFactory
    {
        public Review CreateReview(string title, string description, MusicUnit reviewable, User creator, double rating)
        {
            return new Review(Guid.NewGuid().ToString(), title, description, DateTime.Now, rating, reviewable, creator, new List<User>());
        }
    }
}
