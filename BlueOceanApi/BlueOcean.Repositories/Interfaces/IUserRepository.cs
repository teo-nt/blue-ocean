using BlueOcean.Data.Models;

namespace BlueOcean.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> GetUserAsync(string username, string password);
    }
}
