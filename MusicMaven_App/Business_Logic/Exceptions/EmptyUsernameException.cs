using System;
namespace Business_Logic.Exceptions
{
	public class EmptyUsernameException : Exception
	{
		public EmptyUsernameException() : base("Username cannot be empty.")
		{
		}
	}
}

