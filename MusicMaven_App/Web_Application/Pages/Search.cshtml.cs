﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Business_Logic.Interfaces.IServices;
using Web_Application.DTOs.MusicUnitDTOs;
using Web_Application.DTOs;
using Web_Application.Helpers;
{
	public class SearchModel : PageModel
    {
        private IMusicUnitService musicUnitService;
        private IUserService userService;
        {
            if (!string.IsNullOrEmpty(searchString))
            {
            else
                return Redirect(PageRoutes.Index);
            }
        }
        public IActionResult OnGetMusicUnitInfo(string id, MUSIC_UNIT_TYPE unitTyoe)
            switch (unitTyoe)
            {
            }

        }

    }
}