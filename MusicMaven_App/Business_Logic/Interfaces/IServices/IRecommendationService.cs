using System;
using Business_Logic.Models;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface IRecommendationService
	{        Task<List<MusicUnit>> GetRecommendationsForUser(User user, int numRecommendations);        Task Setup();    }
}

