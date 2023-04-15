using System;
namespace Business_Logic.Exceptions
{
	public class EmptyPasswordException : Exception
	{
		public EmptyPasswordException() : base("Password cannot be empty.")
		{
		}
	}
}

