using System.Threading.Tasks;

namespace BlueOcean.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();

        IComplainRepository ComplainRepository { get; }
        ILocationRepository LocationRepository { get; }
        IRoleRepository RoleRepository { get; }
        ITicketRepository TicketRepository { get; }
        IUserRepository UserRepository { get; }
        IBoatRepository BoatRepository { get; }
        IBoatCategoryRepository BoatCategoryRepository { get; }

        Task DisposeAsync();
    }
}
