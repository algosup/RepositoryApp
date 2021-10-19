using Npgsql;

namespace InfrastructureLayer
{
    public class ConnectionProvider
    {
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(DbConnection.ConnectionString);
        }
    }
}