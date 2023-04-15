using System;
namespace Business_Logic.Exceptions
{
	public class EmailExistException : Exception
	{        public EmailExistException(string email) : base($"The email '{email}' already exists.")        {        }    }
}

