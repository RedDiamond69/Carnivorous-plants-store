using OnlineStore.DataProvider.Context;
using OnlineStore.DataProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineStore.DataProvider.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        protected ApplicationDbContext Context => _context;

        public Repository(ApplicationDbContext context) => _context = context;

        public TEntity Get(string guid) => Context.Set<TEntity>().Find(guid);

        public IEnumerable<TEntity> GetAll() => Context.Set<TEntity>().AsNoTracking().ToList();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) 
            => Context.Set<TEntity>().AsNoTracking().Where(predicate).ToList();

        public void Add(TEntity entity) => Context.Set<TEntity>().Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().AddRange(entities);

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().RemoveRange(entities);
    }
}
