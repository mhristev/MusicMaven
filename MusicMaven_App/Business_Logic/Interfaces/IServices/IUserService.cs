using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces.IServices
{
	public interface IUserService
	{        User? GetUserById(string id);        User? GetUserByEmail(string email);        List<User> FindUsersByKeywordInUsername(string keyword);        List<User> GetAllUsers();
        void CreateUser(User user);
    }
}

