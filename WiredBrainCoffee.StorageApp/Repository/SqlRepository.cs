using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _DbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _DbSet = _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
#pragma warning disable CS8603
            return _DbSet.Find(id);
        }

        public void Add(T item)
        {
            _DbSet.Add(item);
        }

        public void Remove(T item)
        {
            _DbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
