﻿using Business_Logic.Models;
using System.ComponentModel.DataAnnotations;
using Web_Application.DTOs.MusicUnitDTOs;

namespace Web_Application.DTOs
{
    public class ReviewDTO
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public DateTime? CreationDate { get; set; }

        //[Required]
        //[Range(1.0, 10.0, ErrorMessage = "Please enter a number between 1 and 10.")]
        //[DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        public double Rating { get; set; }

        public MusicUnitDTO? MusicUnit { get; set; }
        public UserDTO? Creator { get; set; }
        public List<UserDTO>? LikedBy { get; set; }

        public static ReviewDTO FromReview(Review review)
        {
            ReviewDTO reviewDTO = new ReviewDTO();
            reviewDTO.Id = review.Id;
            reviewDTO.Title = review.Title;
            reviewDTO.Description = review.Description;
            reviewDTO.CreationDate = review.CreationDate;
            reviewDTO.Rating = review.Rating;
            reviewDTO.Creator = UserDTO.FromUser(review.Creator);
            reviewDTO.MusicUnit = MusicUnitDTO.FromMusicUnit(review.MusicUnit);
            reviewDTO.LikedBy = review.LikedBy.Select(u => UserDTO.FromUser(u)).ToList();
            return reviewDTO;
        }
    }

}
