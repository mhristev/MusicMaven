using System;
using Business_Logic.Models;

namespace Business_Logic.Services
{
	public class UserAuthenticationService
	{
		private readonly UserService userService;
		public UserAuthenticationService(UserService us)
		{
			userService = us;
		}

		public User? AuthenticateUser(string email, string password)
		{
			//TODO propper auth
			User? user = userService.GetUserByEmail(email);
			if (user != null) {
				if (user.Password == password)
					return user;
			}
			return null;
		}
	}
}

