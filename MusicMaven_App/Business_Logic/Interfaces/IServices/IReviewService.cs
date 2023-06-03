using System;
using Business_Logic.Models;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface IReviewService
	{        List<Review> GetAll();
        void AddReview(string title, string description, double rating, MusicUnit musicUnit, User creator);
        List<Review> GetReviewsForMusicUnit(MusicUnit unit);        Review? GetReviewWithId(string id);        void LikeReviewByCurrentUser(Review review);        List<Review> GetReviewsForUser(User user);        double GetAverageRatingForReviews(List<Review> reviews);        string GetDescriptionOfHighestRatedReviewForMusicUnit(MusicUnit musicUnit);        List<Review> GetLatestReviews(int count);    }
}

