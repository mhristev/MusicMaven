using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces
{
	public interface IReviewRepository: IRepository<Review>
	{
		List<Review> GetReviewsForMusicUnitId(string id);		void LikeReviewIdByUserId(string reviewId, string userId);
    }
}

