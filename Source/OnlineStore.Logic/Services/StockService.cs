using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Model.BusinessObjects;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Services
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork _work;

        public StockService(IUnitOfWork unitOfWork)
        {
            _work = unitOfWork;
        }

        public void Add(StockDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<StockDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<StockDTO> Find(Expression<Func<StockDTO, bool>> predicate)
        {
            var stocks = _work.Stocks.GetAll().Select(s => new StockBL(s).GetDTO()).Where(predicate.Compile());
            return stocks;
        }

        public StockDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StockDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(StockDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<StockDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(StockDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
