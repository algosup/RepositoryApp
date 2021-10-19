using System;
using InfrastructureLayer;

namespace RightManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataManager = new DataManager();
            var userList = dataManager.GetUsers();

            foreach (var user in userList)
            {
                Console.WriteLine($"User Id {user.UserId}, UserName = {user.UserName}");
            }
        }

    }
}
