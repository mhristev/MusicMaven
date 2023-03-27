using System;
using Web_Application.DTOs;

namespace Web_Application.Models
{
	public class CreateReviewModel
	{
		public ReviewDTO ReviewDTO { get; set; }
		public string MusicUnitId { get; set; }
	}
}

