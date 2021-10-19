using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer;

namespace InfrastructureLayer
{
    public class DataManager
    {
        public IDataLoader DataLoader { get; }

        public DataManager() : this(new DataLoader())
        {
        }

        public DataManager(IDataLoader dataLoader)
        {
            DataLoader = dataLoader;
        }

        public List<User> GetUsers()
        {
            var users = DataLoader.GetUsers();

            // Check that all users are ok
            var usersWithEmptyPassword = users.Where(user => string.IsNullOrEmpty(user.HashedPassword)).ToList();
            var nbrUserWithEmptyPassword = usersWithEmptyPassword.Count();
            if (nbrUserWithEmptyPassword > 0)
            {
                string errorMessage;
                if (nbrUserWithEmptyPassword == 1)
                {
                    var user = usersWithEmptyPassword.First();
                     errorMessage = $"Error : The User {user.UserName} has an empty password";
                }
                else
                {
                    var userNames = string.Join(',',usersWithEmptyPassword.Select(x => x.UserName));
                    errorMessage = $"Error : The Users {userNames} have an empty password";
                }

                throw new Exception(errorMessage);
            }

            return users;
        }


    }
}
