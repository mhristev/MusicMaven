﻿using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces
{
	public interface IUserRepository : IRepository<User>
	{        User? GetUserByEmail(string email);        List<User> FindUsersByKeywordInUsername(string keyword);        List<User> GetLikedByUsersForReviewId(string reviewId);        void FollowUserFromUser(string toFollowId, string fromUserId);        void UnFollowUserFromUser(string toUnFollowId, string fromUserId);    }
}

