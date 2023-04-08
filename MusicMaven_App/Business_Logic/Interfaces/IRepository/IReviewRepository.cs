﻿using System;
using Business_Logic.Models;
{
	public interface IReviewRepository: IRepository<Review>
	{
		List<Review> GetReviewsForMusicUnitId(string id);
		List<Review> GetReviewsForuserId(string id);
}
