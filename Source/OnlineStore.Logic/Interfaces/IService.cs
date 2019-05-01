using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Interfaces
{
    public interface IService<TModel> where TModel : class
    {
        TModel Get(string guid);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);

        void Add(TModel model);
        void AddRange(IEnumerable<TModel> models);

        void Update(TModel model);

        void Remove(TModel model);
        void RemoveRange(IEnumerable<TModel> models);
    }
}
