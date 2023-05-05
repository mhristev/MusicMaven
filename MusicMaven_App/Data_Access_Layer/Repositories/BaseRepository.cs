using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.Repositories
{
    public abstract class BaseRepository
    {
        private readonly string connectionString = "Server=localmac;Database=MUSIC_MAVEN;User Id=SA;Password=nepokornite9;TrustServerCertificate=True;";        protected List<T> ExecuteQuery<T>(string sql, Func<IDataReader, T> map, Action<IDbCommand> configureCommand = null)        {            var result = new List<T>();            using (var connection = new SqlConnection(connectionString))            {                using (var command = connection.CreateCommand())                {                    command.CommandText = sql;                    command.CommandType = CommandType.Text;                    configureCommand?.Invoke(command);                    connection.Open();                    using (var reader = command.ExecuteReader())                    {                        while (reader.Read())                        {                            result.Add(map(reader));                        }                    }                }            }            return result;        }


        protected void ExecuteNonQuery(string sql, Action<IDbCommand> configureCommand = null)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    configureCommand?.Invoke(command);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

