using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFrameworkCore
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        // ADD, UPDATE ----------------------------------------------------
        public TEntity ReturnEntity(TEntity entity, EntityState state)
        {
            using var context = new TContext();
            var operationEntity = context.Entry(entity);
            operationEntity.State = state;
            context.SaveChanges();
            return entity;
        }

        // ASYNC-ADD, ASYNC-UPDATE ----------------------------------------
        public async Task<TEntity> AsyncReturnEntity(TEntity entity, EntityState state)
        {
            using var context = new TContext();
            var operationEntity = context.Entry(entity);
            operationEntity.State = state;
            await context.SaveChangesAsync();
            return entity;
        }

        public TEntity Add(TEntity entity)
        {
            return ReturnEntity(entity, EntityState.Added);
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            return AsyncReturnEntity(entity, EntityState.Added);
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Update(TEntity entity)
        {
            return ReturnEntity(entity, EntityState.Modified);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return AsyncReturnEntity(entity, EntityState.Modified);
        }
    }
}
