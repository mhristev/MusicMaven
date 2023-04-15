using System;
namespace Business_Logic.Exceptions
{
	public class InvalidEmailException : Exception
	{
		public InvalidEmailException(string email) : base($"Email '{email}' is not in a valid format.")
		{
		}
	}
}

