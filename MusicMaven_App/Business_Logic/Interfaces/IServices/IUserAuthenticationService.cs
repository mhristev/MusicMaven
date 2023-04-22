using System;
using Business_Logic.Models;namespace Business_Logic.Interfaces.IServices
{
	public interface IUserAuthenticationService
	{        User? AuthenticateUser(string email, string password);    }
}

