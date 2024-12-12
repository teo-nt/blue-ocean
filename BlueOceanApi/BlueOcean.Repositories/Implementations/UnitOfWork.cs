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

        public IComplainRepository ComplainRepository => new ComplainRepository(_context);
        public ILocationRepository LocationRepository => new LocationRepository(_context);
        public IRoleRepository RoleRepository => new RoleRepository(_context);
        public ITicketRepository TicketRepository => new TicketRepository(_context);
        public IUserRepository UserRepository => new UserRepository(_context);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
