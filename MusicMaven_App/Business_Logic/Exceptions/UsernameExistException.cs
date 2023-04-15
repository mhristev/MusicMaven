using System;
namespace Business_Logic.Exceptions
{
	    public class UsernameExistException : Exception
	    {            public UsernameExistException(string username) : base($"The username '{username}' already exists.")        {
            }        }
}

