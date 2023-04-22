using Business_Logic.Models.MusicUnits;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Web_Application.DTOs;
using Web_Application.DTOs.MusicUnitDTOs;
using Business_Logic.Models.Enums;
using Business_Logic.Interfaces.IServices;

namespace Web_Application.Pages
{
    public class ReviewsModel : PageModel
    {
        private IReviewService _reviewService;
        public List<ReviewDTO> Reviews { get; set; } = new List<ReviewDTO>();

        public ReviewsModel(IReviewService reviewService)        {
            this._reviewService = reviewService;
        }
        
        public void OnGet()
        {
            Reviews = _reviewService.GetAll().Select(r => ReviewDTO.FromReview(r)).ToList();
        }

        
    }
}
