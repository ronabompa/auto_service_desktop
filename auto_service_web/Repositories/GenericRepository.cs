using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Linq;

namespace ServiceAutoFINAL.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        TEntity Get(object obj);

        IEnumerable<TEntity> GetAll();
    }
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly DbSet<TEntity> dbSet;
        public MongoContext dbContext;
        
        public GenericRepository(MongoContext context)
        {
            this.dbContext = context;
            this.dbSet = context.Set<TEntity>();
        }
        
        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
            dbContext.SaveChangesAsync();
        }

        public TEntity Get(object obj)
        {
            var entity = dbSet.Find(obj);
            dbContext.SaveChanges();
            dbContext.SaveChangesAsync();
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

    }
}
