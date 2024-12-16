using System.Threading.Tasks;

namespace BlueOcean.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();

        IComplainRepository ComplainRepository { get; }
        ILocationRepository LocationRepository { get; }
        ITicketRepository TicketRepository { get; }
        IUserRepository UserRepository { get; }
        IBoatRepository BoatRepository { get; }

        Task DisposeAsync();
    }
}
