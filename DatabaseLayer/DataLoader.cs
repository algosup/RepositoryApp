using System;
using System.Collections.Generic;
using System.Data;
using DomainLayer;
using Npgsql;

namespace RepositoryLayer
{
    public class DataLoader : IDataLoader
    {
        private NpgsqlConnection Connection { get; }
        public DataLoader()
        {
            var connectionProvider = new ConnectionProvider();
            Connection = connectionProvider.GetConnection();
        }

        public DataLoader(IDbConnection dbConnection)
        {
            Connection = null;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();

            Connection.Open();

            var query = "Select * from Users;";

            var cmd = new NpgsqlCommand(query, Connection);
            var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var user = new User
                {
                    UserId = dataReader.GetInt32(0),
                    UserName = dataReader.GetString(1),
                    HashedPassword = dataReader.GetString(2),
                    Email = dataReader.GetString(3),
                    CreationDate = dataReader.GetDateTime(4),
                    LastLoginDate = dataReader.GetDateTime(5)
                };
                users.Add(user);
            }

            return users;
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleDetails> GetRoleDetails()
        {
            var roleDatails = new List<RoleDetails>();

            Connection.Open();

            var query = "Select * from RoleDetailsView;";

            var cmd = new NpgsqlCommand(query, Connection);
            var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var role = new Role
                {
                    RoleName = dataReader.GetString(0),
                    RoleDescription = dataReader.GetString(1)
                };

                var roleDetail = new RoleDetails();

                var rights = new List<Right>();

                roleDatails.Add(roleDetail);
            }

            return roleDatails;
        }
    }
}
