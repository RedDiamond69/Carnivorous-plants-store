using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IUnitOfWork _work;

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _work = unitOfWork;
        }

        public void Add(ProviderDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ProviderDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<ProviderDTO> Find(Expression<Func<ProviderDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ProviderDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProviderDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ProviderDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ProviderDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(ProviderDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
