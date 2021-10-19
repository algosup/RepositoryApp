using System;
using System.Collections.Generic;

namespace DomainLayer
{
    public class Role
    {
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }

    public class Right
    {
        public string RightName { get; set; }
        public string RightDescription { get; set; }
    }

    public class RoleDetails
    {
        public Role Role { get; set; }
        public IEnumerable<Right> Rights { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}