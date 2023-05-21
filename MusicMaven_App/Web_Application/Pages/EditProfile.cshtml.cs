using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;using Business_Logic.Interfaces.IServices;using Business_Logic.Interfaces;using Business_Logic.Models;using Web_Application.DTOs.MusicUnitDTOs;using Web_Application.Helpers;using Microsoft.AspNetCore.Authentication;using Microsoft.AspNetCore.Authentication.Cookies;using System.Security.Claims;namespace Web_Application.Pages.Single
{
	public class EditProfileModel : PageModel
    {
        public UserDTO userDTO { get; private set; }

        [BindProperty]
        public UserDTO editedUser { get; set; }
       

        private IUserService userService;
        private ICurrentUserProvider currentUserProvider;

        public EditProfileModel(IUserService userService, ICurrentUserProvider currentUserProvider)        {
            this.userService = userService;
            this.currentUserProvider = currentUserProvider;
        }

        public void OnGet()
        {
            string? id = currentUserProvider.GetCurrentUserId();
            if (id != null)            {
                User? user = userService.GetUserById(id);
                if (user != null)                {
                    userDTO = UserDTO.FromUser(user);
                }
                
            }
        }        public IActionResult OnPost()        {            // Clear validation errors for properties you want to exclude            ModelState.Remove("editedUser.Id");            ModelState.Remove("editedUser.Image");            ModelState.Remove("editedUser.Following");            ModelState.Remove("editedUser.Followers");            if (ModelState.IsValid)            {                string? id = currentUserProvider.GetCurrentUserId();                if (id != null)                {                    User? user = userService.GetUserById(id);                    if (user != null)                    {                        user.Username = editedUser.Username;                        user.Email = editedUser.Email;                        userService.UpdateUser(user);                        userDTO = editedUser;                        List<Claim> claims = new List<Claim>();                        claims.Add(new Claim(ClaimTypes.Name, user.Username));                        claims.Add(new Claim("Id", user.Id));                        ClaimsIdentity cid = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);                        AuthenticationHttpContextExtensions.SignInAsync(HttpContext, CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(cid));                        return RedirectToPage(PageRoutes.Profile, new { id = id });                    }                }            }            return RedirectToPage(PageRoutes.EditProfile);        }


    }
}
