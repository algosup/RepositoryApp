using System.Collections.Generic;

namespace DomainLayer
{
    public interface IDataLoader
    {
        // CRUD : CREATE, READ, UPDATE, DELETE
        List<User> GetUsers(); // Read
        User GetUserById(int userId); // Read
        void AddUser(User user); // Create
        void UpdateUser(User user); // Update

        void DeleteUser(User user); // Delete

        IEnumerable<RoleDetails> GetRoleDetails();
    }
}