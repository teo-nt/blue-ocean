
using BlueOcean.Data;
using BlueOcean.Data.Models;
using BlueOcean.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Repositories.Implementations
{
    public class BoatRepository : BaseRepository<Boat>, IBoatRepository
    {

        public BoatRepository(BlueOceanDbContext dbContext) : base(dbContext) { }


        public async Task<List<Boat>> GetAllBoatsAsync()
        {
            return await _context.Boats
                .Include(b => b.Location)
                .Include(b => b.Owner)
                .ToListAsync();
        }

        public async Task<List<Boat>> GetBoatAsync(string boatId)
        {
            return await _context.Boats
                .Include(b => b.Location)
                .Include(b => b.Owner)
                .Where(b => b.Id == boatId)
                .ToListAsync();
        }




    }

}
