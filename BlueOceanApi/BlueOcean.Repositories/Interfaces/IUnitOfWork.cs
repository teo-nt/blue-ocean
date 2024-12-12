namespace BlueOcean.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IComplainRepository ComplainRepository { get; }
        ILocationRepository LocationRepository { get; }
        IRoleRepository RoleRepository { get; }
        ITicketRepository TicketRepository { get; }
        IUserRepository UserRepository { get; }

        Task<bool> SaveAsync();
    }
}
