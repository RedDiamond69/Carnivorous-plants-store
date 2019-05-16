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
    public class ProductService : IProductService
    {
        public void Add(ProductDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ProductDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> Find(Expression<Func<ProductDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ProductDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ProductDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
