using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Application.Models
{
	public class RegisterModel
	{
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
    }
}

