using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Application
{
	public class LoginModel
	{
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
	}
}

