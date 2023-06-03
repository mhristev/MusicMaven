using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces
{
	public interface IReviewRepository: IRepository<Review>
	{
		List<Review> GetReviewsForMusicUnitId(string id);		void LikeReviewIdByUserId(string reviewId, string userId);
		List<Review> GetReviewsForuserId(string id);		double GetRatingFor(string userId, string reviewedMusicUnitId);		string GetDescriptionOfHighestRatedReviewForMusicUnit(string musicUnitId);		List<Review> GetLatestReviews(int count);    }
}

