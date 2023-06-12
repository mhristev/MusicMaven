using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.Models;

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
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(RegisterModel.Password);
                    User user = new User(Guid.NewGuid().ToString(), RegisterModel.Username, RegisterModel.Email, hashedPassword , new List<User>(), new List<User>(), USER_TYPE.NORMAL, "NONE");
                    _userService.CreateUser(user);
                    return RedirectToPage("/SignIn");
                }
                catch (ArgumentException ex)
                {

                    ModelState.AddModelError("Exist", ex.Message);
                }
            }
            return Page();

        }

    }

}
