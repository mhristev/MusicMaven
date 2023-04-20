using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public static class ReviewFactory
    {
        //private IMusicUnitRepository _musicUnitRepository;
        //private IRepository<Review> _reviewRepository;

        //public ReviewFactory(IMusicUnitRepository musicUnitRepository, IRepository<Review> reviewRepository)        //{
        //    _reviewRepository = reviewRepository;
        //    _musicUnitRepository = musicUnitRepository
        //}

        
        public static Review CreateReview(string title, string description, MusicUnit reviewable, User creator, double rating)
        {
            return new Review(Guid.NewGuid().ToString(), title, description, DateTime.Now, rating, reviewable, creator, new List<User>());
        }
    }
}
