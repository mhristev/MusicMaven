using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;using Business_Logic.Interfaces.IServices;using Business_Logic.Interfaces;using Business_Logic.Models;using Web_Application.DTOs.MusicUnitDTOs;namespace Web_Application.Pages.Single
{
	public class EditProfileModel : PageModel
    {

        public UserDTO userDTO { get; private set; }
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
        }

        public void OnPost(UserDTO editedUser)        {
            string name = editedUser.Username;
            
        }
    }
}
