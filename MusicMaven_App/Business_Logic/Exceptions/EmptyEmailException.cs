using System;
namespace Business_Logic.Exceptions
{
	public class EmptyEmailException : Exception
	{        public EmptyEmailException() : base("Email cannot be empty.")        {        }    }
}

