using System;
using System.Collections.Generic;using System.Data;using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
using Microsoft.Data.SqlClient;

namespace Data_Access_Layer.Repositories
{
	public class ReviewRepository: BaseRepository, IReviewRepository
	{
        IMusicUnitRepository musicUnitRepository;
        IUserRepository userRepository;

		public ReviewRepository(IMusicUnitRepository musicUnitRepository, IUserRepository userRepository)
		{
            this.musicUnitRepository = musicUnitRepository;
            this.userRepository = userRepository;
		}
        private Review MapReview(IDataReader reader)        {            string id = reader.GetString(reader.GetOrdinal("id"));            string title = reader.GetString(reader.GetOrdinal("title"));            string description = reader.GetString(reader.GetOrdinal("description"));            DateTime creationDate = reader.GetDateTime(reader.GetOrdinal("creationDate"));            double rating = reader.GetDouble(reader.GetOrdinal("rating"));            string musicUnitId = reader.GetString(reader.GetOrdinal("musicUnitId"));            MusicUnit? musicUnit = musicUnitRepository.GetById(musicUnitId);            string creatorId = reader.GetString(reader.GetOrdinal("creatorId"));            User? creator = userRepository.GetById(creatorId);            List<User> likedBy = userRepository.GetLikedByUsersForReviewId(id);            return new Review(id, title, description, creationDate, rating, musicUnit, creator, likedBy);        }

        public void Delete(string id)
        {
            Review? review = GetById(id);
            if (review != null)            {                string sql = @"DELETE FROM Review WHERE id = @id;                   UPDATE MusicUnit
                   SET avgRating = (SELECT AVG(rating) FROM Review WHERE musicUnitId = @musicUnitId)
                   WHERE id = @musicUnitId";                ExecuteNonQuery(sql, command =>                {                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });                    command.Parameters.Add(new SqlParameter("@musicUnitId", SqlDbType.NVarChar) { Value = review.MusicUnit.Id });                });            }
        }

        public List<Review> GetAll()
        {
            string sql = "SELECT * FROM Review ORDER BY creationDate DESC";            return ExecuteQuery(sql, MapReview);
        }

        public Review? GetById(string id)
        {
            string sql = @"SELECT *
                   FROM Review
                   WHERE id = @id";            List<Review> reviews = ExecuteQuery(sql, MapReview, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });            });            return reviews.FirstOrDefault();
        }        public List<Review> GetReviewsForMusicUnitId(string id)        {            string sql = @"SELECT r.id, r.title, r.description, r.creationDate, r.rating, r.musicUnitId, r.creatorId 
                    FROM Review r 
                    WHERE r.musicUnitId = @id 
                    ORDER BY r.creationDate DESC";            return ExecuteQuery(sql, MapReview, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });            });        }        public List<Review> GetReviewsForuserId(string id)        {            string query = "SELECT * FROM Review WHERE creatorId = @id ORDER BY creationDate DESC";            return ExecuteQuery(query, MapReview, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });            });        }        public void Insert(Review entity)
        {
            string sql = @"INSERT INTO Review (id, title, description, creationDate, rating, musicUnitId, creatorId)
                   VALUES (@id, @title, @description, @creationDate, @rating, @musicUnitId, @creatorId);

                   UPDATE MusicUnit
                   SET avgRating = (SELECT AVG(rating) FROM Review WHERE musicUnitId = @musicUnitId)
                   WHERE id = @musicUnitId";                        ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar) { Value = entity.Title });                command.Parameters.Add(new SqlParameter("@description", SqlDbType.Text) { Value = entity.Description });                command.Parameters.Add(new SqlParameter("@creationDate", SqlDbType.DateTime) { Value = entity.CreationDate });                command.Parameters.Add(new SqlParameter("@rating", SqlDbType.Float) { Value = entity.Rating });                command.Parameters.Add(new SqlParameter("@musicUnitId", SqlDbType.NVarChar) { Value = entity.MusicUnit.Id });                command.Parameters.Add(new SqlParameter("@creatorId", SqlDbType.NVarChar) { Value = entity.Creator.Id });            });
        }        public void LikeReviewIdByUserId(string reviewId, string userId)        {            string sql = @"IF EXISTS(SELECT * FROM ReviewLike WHERE reviewId = @reviewId AND userId = @userId)                            BEGIN                                DELETE FROM ReviewLike WHERE reviewId = @reviewId AND userId = @userId                            END                           ELSE                            BEGIN                                INSERT INTO ReviewLike (reviewId, userId) VALUES (@reviewId, @userId)                            END";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@reviewId", SqlDbType.NVarChar) { Value = reviewId });                command.Parameters.Add(new SqlParameter("@userId", SqlDbType.NVarChar) { Value = userId });            });        }        public void Update(Review entity)
        {
            string sql = @"UPDATE Review
                   SET title = @title, description = @description, rating = @rating
                   WHERE id = @id;                   UPDATE MusicUnit
                   SET avgRating = (SELECT AVG(rating) FROM Review WHERE musicUnitId = @musicUnitId)
                   WHERE id = @musicUnitId";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar) { Value = entity.Title });                command.Parameters.Add(new SqlParameter("@description", SqlDbType.Text) { Value = entity.Description });                command.Parameters.Add(new SqlParameter("@rating", SqlDbType.Float) { Value = entity.Rating });            });
        }        public double GetRatingFor(string userId, string reviewedMusicUnitId)        {            string sql = "SELECT rating FROM Review WHERE musicUnitId = @musicUnitId AND creatorId = @creatorId";            return ExecuteScalar<double>(sql, command =>            {                command.Parameters.Add(new SqlParameter("@musicUnitId", SqlDbType.NVarChar) { Value = reviewedMusicUnitId });                command.Parameters.Add(new SqlParameter("@creatorId", SqlDbType.NVarChar) { Value = userId });            });        }        public string GetDescriptionOfHighestRatedReviewForMusicUnit(string musicUnitId)        {            string sql = "SELECT [description] from Review where musicUnitId=@musicUnitId";            return ExecuteScalar<string>(sql, command =>            {                command.Parameters.Add(new SqlParameter("@musicUnitId", SqlDbType.NVarChar) { Value = musicUnitId });            });        }        public List<Review> GetLatestReviews(int count)        {            string sql = string.Empty;            if (count < 0)            {                sql = "SELECT * FROM Review ORDER BY creationDate DESC";                return ExecuteQuery(sql, MapReview);            }            else            {                sql = "SELECT TOP(@count) * FROM Review ORDER BY creationDate DESC";                return ExecuteQuery(sql, MapReview, command =>                {                    command.Parameters.Add(new SqlParameter("@count", SqlDbType.Int) { Value = count });                });            }        }    }
}

