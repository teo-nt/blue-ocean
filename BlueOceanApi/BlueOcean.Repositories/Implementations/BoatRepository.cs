
using BlueOcean.Data;
using BlueOcean.Data.Models;
using BlueOcean.Repositories.Interfaces;

namespace BlueOcean.Repositories.Implementations
{
    public class BoatRepository : BaseRepository<Boat>, IBoatRepository
    {

        public BoatRepository(BlueOceanDbContext dbContext) : base(dbContext) { }

    }

}
