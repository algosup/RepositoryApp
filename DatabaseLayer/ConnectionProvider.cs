using System;
using System.Collections.Generic;
using Npgsql;

namespace ApiClientKata
{
    public class ConnectionProvider
    {
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(DbConnection.ConnectionString);
        }
        
    }
}