using Microsoft.EntityFrameworkCore;
using OTS.Domain.Interfaces;

namespace OTS.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OtsDbContext _context;
        protected readonly DbSet<T> _entities;

        public Repository(OtsDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
