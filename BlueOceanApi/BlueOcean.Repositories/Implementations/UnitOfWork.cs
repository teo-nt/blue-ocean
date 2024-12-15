using BlueOcean.Data;
using BlueOcean.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Repositories.Implementations
{
    public class UnitOfWork
    {
        private readonly BlueOceanDbContext _context;
        private IComplainRepository? _complainRepository;
        private ILocationRepository? _locationRepository;
        private IRoleRepository? _roleRepository;
        private ITicketRepository? _ticketRepository;
        private IUserRepository? _userRepository;
        private IBoatRepository? _boatRepository;
        private IBoatCategoryRepository? _boatCategoryRepository;

        public UnitOfWork(BlueOceanDbContext context)
        {
            _context = context;
        }

        public IComplainRepository ComplainRepository => _complainRepository ??= new ComplainRepository(_context);
        public ILocationRepository LocationRepository => _locationRepository ??= new LocationRepository(_context);
        public IRoleRepository RoleRepository => _roleRepository ??= new RoleRepository(_context);
        public ITicketRepository TicketRepository => _ticketRepository ??= new TicketRepository(_context);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IBoatRepository BoatRepository => _boatRepository ??= new BoatRepository(_context);
        public IBoatCategoryRepository BoatCategoryRepository => _boatCategoryRepository ??= new BoatCategoryRepository(_context);
        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
