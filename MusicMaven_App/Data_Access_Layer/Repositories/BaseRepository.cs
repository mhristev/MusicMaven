using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.Repositories
{
    public abstract class BaseRepository
    {
        private readonly string connectionString = "Server=mssqlstud.fhict.local;Database=dbi502270_musicmaven;User Id=dbi502270_musicmaven;Password=password;TrustServerCertificate=True;";        protected List<T> ExecuteQuery<T>(string sql, Func<IDataReader, T> map, Action<IDbCommand> configureCommand = null)        {            var result = new List<T>();            using (var connection = new SqlConnection(connectionString))            {                using (var command = connection.CreateCommand())                {                    command.CommandText = sql;                    command.CommandType = CommandType.Text;                    configureCommand?.Invoke(command);                    connection.Open();                    using (var reader = command.ExecuteReader())                    {                        while (reader.Read())                        {                            result.Add(map(reader));                        }                    }                }            }            return result;        }        protected double ExecuteScalar(string sql, Action<IDbCommand> configureCommand = null)        {            double result = 0;            using (var connection = new SqlConnection(connectionString))            {                using (var command = connection.CreateCommand())                {                    command.CommandText = sql;                    command.CommandType = CommandType.Text;                    configureCommand?.Invoke(command);                    connection.Open();                    var scalarResult = command.ExecuteScalar();                    if (scalarResult != null && scalarResult != DBNull.Value)                    {                        result = Convert.ToDouble(scalarResult);                    }                }            }            return result;        }

        protected string ExecuteScalarReturnString(string sql, Action<IDbCommand> configureCommand = null)        {            string result = string.Empty;            using (var connection = new SqlConnection(connectionString))            {                using (var command = connection.CreateCommand())                {                    command.CommandText = sql;                    command.CommandType = CommandType.Text;                    configureCommand?.Invoke(command);                    connection.Open();                    var scalarResult = command.ExecuteScalar();                    if (scalarResult != null && scalarResult != DBNull.Value)                    {                        result = (string)scalarResult;                    }                }            }            return result;        }


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

