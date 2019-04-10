using OnlineStore.DataProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Infrastructure
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IDbSet<TEntity> _entity;
        
        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _entity = _applicationDbContext.Set<TEntity>();
        }

        public virtual void Create(TEntity item)
        {
            _entity.Add(item);
        }

        public virtual void Delete(TEntity item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Deleted;
        }

        public virtual void Delete(int id)
        {
            _applicationDbContext.Entry(_entity.Find(id)).State = EntityState.Deleted;
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return _entity.ToList();
        }

        public virtual TEntity Get(int id)
        {
            return _entity.Find(id);
        }

        public virtual IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _entity.Where(predicate).ToList();
        }

        public virtual void Update(TEntity item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }
    }
}
