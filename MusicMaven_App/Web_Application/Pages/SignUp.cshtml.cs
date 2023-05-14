using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.Models;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Factories;
using Business_Logic.Models;
using Business_Logic.Models.Enums;

namespace Web_Application.Pages
{
	public class SignUpModel : PageModel
    {
        [BindProperty]
        public RegisterModel RegisterModel { get; set; }

        private IUserService _userService;

        public SignUpModel(IUserService userService)
        {
            this._userService = userService;
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
                    User user = UserFactory.CreateUser(RegisterModel.Username, RegisterModel.Email, RegisterModel.Password, "NONE");
                    _userService.CreateUser(user);
                    return RedirectToPage("/SignIn");
                } catch (ArgumentException ex) {

                    ModelState.AddModelError("Exist", ex.Message);
                }
            }
            return Page();

        }

    }
    
}
