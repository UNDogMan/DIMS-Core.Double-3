using System;
using System.Linq;
using System.Threading.Tasks;
using DIMS_Core.DataAccessLayer.Exceptions;
using DIMS_Core.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<TEntity> Set;

        protected Repository(DbContext context)
        {
            _context = context;
            Set = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Set.AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            ExceptionHelper.CheckId(id);

            TEntity objectFromDB = await Set.FindAsync(id);

            ExceptionHelper.CheckEntityExists(objectFromDB, nameof(GetById));

            return objectFromDB;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            var task = await Set.AddAsync(entity);
            return task.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = Set.Update(entity);
            return updatedEntity.Entity;
        }

        public async Task Delete(int id)
        {
            var entity = await Set.FindAsync(id);
            Set.Remove(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}