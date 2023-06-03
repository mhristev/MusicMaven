using System;
using System.Data;using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.Enums;using Microsoft.Data.SqlClient;namespace Data_Access_Layer.Repositories
{    public class UserRepository : BaseRepository, IUserRepository    {

        public User MapUser(IDataReader reader)        {            var user = new User();            user.Id = reader.GetString(reader.GetOrdinal("id"));            user.Username = reader.GetString(reader.GetOrdinal("username"));            user.Email = reader.GetString(reader.GetOrdinal("email"));            user.Password = reader.GetString(reader.GetOrdinal("hashedPassword"));            user.Image = reader.GetString(reader.GetOrdinal("image"));            user.Type = (USER_TYPE)Enum.Parse(typeof(USER_TYPE), reader.GetString(reader.GetOrdinal("type")));            return user;        }

        private List<User> GetUserFollowing(string userId)        {            string sql = "SELECT u.* FROM [User] u JOIN UserFollowing f ON u.id = f.followingId WHERE f.userId = @userId";            return ExecuteQuery(sql, MapUser, command => {                command.Parameters.Add(new SqlParameter("@userId", SqlDbType.NVarChar) { Value = userId });            });        }        private List<User> GetUserFollowers(string userId)        {            string sql = "SELECT u.* FROM [User] u JOIN UserFollowing f ON u.id = f.userId WHERE f.followingId = @userId";            return ExecuteQuery(sql, MapUser, command => {                command.Parameters.Add(new SqlParameter("@userId", SqlDbType.NVarChar) { Value = userId });            });        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM [User] WHERE id = @id";            ExecuteNonQuery(sql, command => {
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });
            });
        }        public List<User> FindUsersByKeywordInUsername(string keyword)        {            string sql = "SELECT * FROM [User] WHERE username LIKE '%' + @keyword + '%';";            var users = ExecuteQuery(sql, MapUser, command => {                command.Parameters.Add(new SqlParameter("@keyword", SqlDbType.NVarChar) { Value = keyword });            });            // Load followers and following for each user            foreach (var user in users)            {                user.Followers = GetUserFollowers(user.Id).AsReadOnly();                user.Following = GetUserFollowing(user.Id).AsReadOnly();            }            return users;        }        public List<User> GetAll()
        {
            string sql = "SELECT * FROM [User]";            var users = ExecuteQuery(sql, MapUser, null);            foreach (User user in users)            {                user.Following = GetUserFollowing(user.Id).AsReadOnly();                user.Followers = GetUserFollowers(user.Id).AsReadOnly();            }            return users;
        }

        public User? GetById(string id)
        {
            string sql = "SELECT * FROM [User] WHERE id = @id";            var users = ExecuteQuery(sql, MapUser, command => {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });            });            if (users.Count > 0)            {                var user = users[0];                user.Followers = GetUserFollowers(user.Id).AsReadOnly();                user.Following = GetUserFollowing(user.Id).AsReadOnly();                return user;            }            else            {                return null;            }
        }        public User? GetUserByEmail(string email)        {            string sql = "SELECT * FROM [User] WHERE email = @email";            var users = ExecuteQuery(sql, MapUser, command => {                command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar) { Value = email });            });            if (users.Count > 0)            {                User user = users[0];                user.Followers = GetUserFollowers(user.Id).AsReadOnly();                user.Following = GetUserFollowing(user.Id).AsReadOnly();                return user;            }            else            {                return null;            }        }        public void Insert(User entity)
        {
            
            string sql = "INSERT INTO [User] (id, username, email, hashedPassword, image, type) " +
                 "VALUES (@id, @username, @email, @password, @image, @type)";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });
                command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = entity.Username });
                command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar) { Value = entity.Email });
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.Text) { Value = entity.Password });
                command.Parameters.Add(new SqlParameter("@image", SqlDbType.Text) { Value = entity.Image });
                command.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });            });
        }

        public void Update(User entity)
        {            string sql = "UPDATE [User] SET username = @username, email = @email, hashedPassword = @password, image = @image, type = @type WHERE id = @id";            ExecuteNonQuery(sql, command => {
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });
                command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = entity.Username });
                command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar) { Value = entity.Email });
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = entity.Password });
                command.Parameters.Add(new SqlParameter("@image", SqlDbType.NVarChar) { Value = entity.Image });
                command.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });
            });
        }

        public List<User> GetLikedByUsersForReviewId(string reviewId)        {            var sql = "SELECT * FROM [User] u JOIN ReviewLike rl ON rl.userId = u.id WHERE rl.reviewId = @reviewId";            var users = ExecuteQuery(sql, MapUser, command =>            {                command.Parameters.Add(new SqlParameter("@reviewId", SqlDbType.NVarChar) { Value = reviewId });            });            return users;        }        public void FollowUserFromUser(string toFollowId, string fromUserId)        {            string sql = "INSERT INTO UserFollowing (userId, followingId) VALUES (@fromUserId, @toFollowId);";            ExecuteNonQuery(sql, command => {
                command.Parameters.Add(new SqlParameter("@fromUserId", SqlDbType.NVarChar) { Value = fromUserId });
                command.Parameters.Add(new SqlParameter("@toFollowId", SqlDbType.NVarChar) { Value = toFollowId });
            });        }        public void UnFollowUserFromUser(string toUnFollowId, string fromUserId)        {            string sql = "DELETE FROM UserFollowing WHERE userId = @fromUserId AND followingId = @toUnFollowId";

            ExecuteNonQuery(sql, command => {
                command.Parameters.Add(new SqlParameter("@fromUserId", SqlDbType.NVarChar) { Value = fromUserId });
                command.Parameters.Add(new SqlParameter("@toUnFollowId", SqlDbType.NVarChar) { Value = toUnFollowId });
            });        }    }
}

