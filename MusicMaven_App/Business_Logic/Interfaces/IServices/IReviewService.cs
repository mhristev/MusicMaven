﻿using System;
using Business_Logic.Models;
{
	public interface IReviewService
	{
        void AddReview(string title, string description, double rating, MusicUnit musicUnit, User creator);
        List<Review> GetReviewsForMusicUnit(MusicUnit unit);
}
