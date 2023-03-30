using System;
using Business_Logic.Models;

namespace Business_Logic.Services
{
	public class UserAuthenticationService
	{
		public UserAuthenticationService()
		{
		}

		public User? AuthenticateUser(string email, string password)
		{
			//TODO propper auth
			User? user = UserService.Instance.GetUserByEmail(email);
			if (user != null) {
				if (user.Password == password)
					return user;
			}
			return null;
		}
	}
}

