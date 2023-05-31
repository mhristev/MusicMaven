﻿using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer.Repositories
{
    public abstract class BaseRepository
    {
        private readonly string connectionString = "Server=mssqlstud.fhict.local;Database=dbi502270_musicmaven;User Id=dbi502270_musicmaven;Password=password;TrustServerCertificate=True;";


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
