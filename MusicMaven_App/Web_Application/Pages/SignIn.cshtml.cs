using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;

namespace Web_Application.Pages
{
	public class SignInModel : PageModel
    {
        [BindProperty]
        public LoginModel LoginModel { get; set; }

        private AuthService authService = new AuthService();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // perform authentication check here
            if (ModelState.IsValid)
            {
                User? result = authService.AuthenticateUser(LoginModel.Email, LoginModel.Password);
                if (result != null)
                {
                    UserDTO user = UserDTO.FromUser(result);
                    // store user data in session
                    HttpContext.Session.Set("IsAuthenticated", BitConverter.GetBytes(true));
                    HttpContext.Session.SetString("Username", user.Username);
                    HttpContext.Session.SetString("UserId", user.Id);

                    // redirect to home page or other authenticated page
                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError("IvalidCredentials", "Invalid email or password");
                }

            }
            return Page();
            
        }
    }
}
