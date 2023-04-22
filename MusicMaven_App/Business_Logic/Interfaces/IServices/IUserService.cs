using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces.IServices
{
	public interface IUserService
	{        User? GetUserById(string id);
        void CreateUser(string email, string username, string password);        User? GetUserByEmail(string email);    }
}

