﻿using System;
using Business_Logic.Interfaces;using Business_Logic.Models;using Business_Logic.Models.MusicUnits;using Business_Logic.Services;using Business_Logic.Interfaces.IServices;namespace Business_Logic.Services
{    public class RecommendationService: IRecommendationService    {        public Dictionary<MusicUnit, Dictionary<User, double>> ratings;        private IUserRepository userRepository;        private IMusicUnitRepository musicUnitRepository;        private IReviewRepository reviewRepository;        public Dictionary<MusicUnit, Dictionary<User, double>> Ratings { private get => ratings;  set => ratings = value; }        public RecommendationService(IUserRepository userRepository, IMusicUnitRepository musicUnitRepository, IReviewRepository reviewRepository)        {            ratings = new Dictionary<MusicUnit, Dictionary<User, double>>();            this.userRepository = userRepository;            this.musicUnitRepository = musicUnitRepository;            List<MusicUnit> musicUnits = musicUnitRepository.GetAll();            List<User> users = userRepository.GetAll();            foreach (var unit in musicUnits)            {                ratings[unit] = new Dictionary<User, double>();                foreach (var user in users)                {                    double rating = reviewRepository.GetRatingFor(user.Id, unit.Id);                    ratings[unit][user] = rating;                }            }        }        public List<MusicUnit> GetRecommendationsForUser(User user, int numRecommendations)        {            List<MusicUnit> unratedUnits = musicUnitRepository.GetUnratedUnits(user.Id);            Dictionary<MusicUnit, double> predictedRatings = new Dictionary<MusicUnit, double>();            foreach (var unratedUnit in unratedUnits)            {                double numerator = 0;                double denominator = 0;                foreach (var ratedUnit in ratings.Keys)                {                    if (ratedUnit.Id == unratedUnit.Id)                        continue;                    double similarity = CalculateSimilarity(ratedUnit, unratedUnit);                    if (ratings[ratedUnit].ContainsKey(user))                    {                        double rating = ratings[ratedUnit][user];                        numerator += similarity * rating;                        denominator += similarity;                    }                }                double predictedRating = denominator != 0 ? numerator / denominator : 0;                predictedRatings[unratedUnit] = predictedRating;            }            var a = predictedRatings;            List<MusicUnit> recommendations = predictedRatings.OrderByDescending(kv => kv.Value)                                                            .Select(kv => kv.Key)                                                            .Take(numRecommendations)                                                            .ToList();            return recommendations;        }        private double CalculateSimilarity(MusicUnit unit1, MusicUnit unit2)        {            MusicUnit matchingUnit1 = null;            MusicUnit matchingUnit2 = null;            foreach (var kvp in ratings)            {                MusicUnit musicUnit = kvp.Key;                if (musicUnit.Id == unit1.Id)                {                    matchingUnit1 = musicUnit;                }                else if (musicUnit.Id == unit2.Id)                {                    matchingUnit2 = musicUnit;                }            }            Dictionary<User, double> ratingsUnit1 = ratings[matchingUnit1];            Dictionary<User, double> ratingsUnit2 = ratings[matchingUnit2];            double dotProduct = 0;            double normUnit1 = 0;            double normUnit2 = 0;            foreach (var user in ratingsUnit1.Keys.Concat(ratingsUnit2.Keys))            {                if (ratingsUnit1.TryGetValue(user, out double ratingUnit1) && ratingsUnit2.TryGetValue(user, out double ratingUnit2))                {                    dotProduct += ratingUnit1 * ratingUnit2;                    normUnit1 += ratingUnit1 * ratingUnit1;                    normUnit2 += ratingUnit2 * ratingUnit2;                }            }            if (normUnit1 == 0 || normUnit2 == 0)                return 0;            double similarity = dotProduct / (Math.Sqrt(normUnit1) * Math.Sqrt(normUnit2));            return similarity;        }
    }

}
