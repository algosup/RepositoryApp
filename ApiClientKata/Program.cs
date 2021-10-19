using System;
using RepositoryLayer;

namespace ApiClientKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new ConnectionProvider();

            var dataManager = new DataManager();
            var userList = dataManager.GetUsers();

            foreach (var user in userList)
            {
                Console.WriteLine($"User Id {user.UserId}, UserName = {user.UserName}");
            }
        }

    }
}
