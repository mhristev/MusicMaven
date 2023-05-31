﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Application.DTOs;
{
	public class EditProfileModel : PageModel
    {
        public UserDTO userDTO { get; private set; }

        [BindProperty]
        public UserDTO editedUser { get; set; }
       

        private IUserService userService;
        private ICurrentUserProvider currentUserProvider;

        public EditProfileModel(IUserService userService, ICurrentUserProvider currentUserProvider)
            this.userService = userService;
            this.currentUserProvider = currentUserProvider;
        }

        public void OnGet()
        {
            string? id = currentUserProvider.GetCurrentUserId();
            if (id != null)
                User? user = userService.GetUserById(id);
                if (user != null)
                    userDTO = UserDTO.FromUser(user);
                }
                
            }
        }


    }
}