using Npgsql;

namespace RepositoryLayer
{
    public class ConnectionProvider
    {
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(DbConnection.ConnectionString);
        }
    }
}