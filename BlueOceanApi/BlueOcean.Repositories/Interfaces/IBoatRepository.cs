

using BlueOcean.Data.Models;

namespace BlueOcean.Repositories.Interfaces
{
    public interface IBoatRepository : IBaseRepository<Boat>
    {
        Task<List<Boat>> GetAllBoatsAsync();
        Task<List<Boat>> GetBoatAsync(string boatId);
    }
}
