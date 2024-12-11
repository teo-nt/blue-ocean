using BlueOcean.Data;
using BlueOcean.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Repositories.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BlueOceanDbContext _context;
        private readonly DbSet<T> _dbSet;

        protected BaseRepository(BlueOceanDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public virtual async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            return entities;
        }

        public virtual async Task<T?> DeleteAsync(Guid id)
        {
            T? existing = await _dbSet.FindAsync(id);
            if (existing is null)
            {
                return null;
            }
            _dbSet.Remove(existing);
            return existing;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T?> GetAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public void Detach(T entity)
        {
            _dbSet.Entry(entity).State = EntityState.Detached;
        }
    }
}
