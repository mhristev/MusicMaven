using System;
using Business_Logic.Exceptions;using System.Text.RegularExpressions;namespace Business_Logic.Services
{
	public static class EmailFormatter
	{		public static bool IsValid(string email)		{            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";			return Regex.IsMatch(email, emailRegex);        }
	}
}

