using System.Threading.Tasks;
using DomainLayer;
using InfrastructureLayer;

namespace BlazorPresentation.Data
{
    public class RightManagementService
    {
        public Task<User[]> GetUsersAsync()
        {
            return Task.FromResult(new DataManager().GetUsers().ToArray());
        }
    }
}
