namespace BlueOcean.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        Task<T?> DeleteAsync(Guid id);
    }
}
