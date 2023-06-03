using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces.IServices
{
	public interface IUserService
	{        User? GetUserById(string id);        User? GetUserByEmail(string email);        List<User> FindUsersByKeywordInUsername(string keyword);        List<User> GetAllUsers();
        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

        void FollowUserFromUser(User toFollow, User fromUser);
        void UnFollowUserFromUser(User toUnFollow, User fromUser);
    }
}

