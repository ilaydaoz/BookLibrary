using BookLibrary.Core.Application.Repositoriy;
using BookLibrary.Core.Domain.Entity;
using BookLibrary.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Persistence.Repositoriy
{
    public class BaseRepository<TEntity,IContext> : IBaseRepository<TEntity> where TEntity : Baseentity
    {
        private readonly BLDbContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(BLDbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }
        public async Task<bool> Add(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await DbSet.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Delete(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = DbSet.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }


        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }



        public Task<List<TEntity>> GetAll()
        {
            return _context.Set<TEntity>().ToListAsync();
            //IEnumerable<TEntity> query = _context.Set<TEntity>();
            //TEntity.Category = connection.QuerySingle<BookCategory>();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            DbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}