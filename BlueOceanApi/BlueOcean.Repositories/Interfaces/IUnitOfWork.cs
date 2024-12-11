namespace BlueOcean.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
