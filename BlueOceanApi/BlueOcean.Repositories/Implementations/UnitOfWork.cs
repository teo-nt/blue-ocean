using BlueOcean.Data;
using BlueOcean.Repositories.Interfaces;

namespace BlueOcean.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlueOceanDbContext _context;

        public UnitOfWork(BlueOceanDbContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
