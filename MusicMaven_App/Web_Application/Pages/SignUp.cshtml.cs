using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.Models;

namespace Web_Application.Pages
{
	public class SignUpModel : PageModel
    {
        [BindProperty]
        public RegisterModel RegisterModel { get; set; }

        private UserService userService;

        public SignUpModel(UserService userService)
        {
            this.userService = userService;
        }

        public void OnGet()
        {
            }

        public IActionResult OnPost()
        {
            // perform authentication check here
            if (ModelState.IsValid)
            {
                try
                {
                    userService.CreateUser(RegisterModel.Email, RegisterModel.Username, RegisterModel.Password);
                    return RedirectToPage("/SignIn");
                } catch (ArgumentException ex) {

                    ModelState.AddModelError("Exist", ex.Message);
                }
            }
            return Page();

        }

    }
    
}
