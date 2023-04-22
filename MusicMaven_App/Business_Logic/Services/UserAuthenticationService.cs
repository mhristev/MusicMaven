using System;
using Business_Logic.Models;
using Business_Logic.Interfaces.IServices;

namespace Business_Logic.Services
{
	public class UserAuthenticationService : IUserAuthenticationService
	{
		private readonly IUserService userService;
		public UserAuthenticationService(IUserService us)
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

