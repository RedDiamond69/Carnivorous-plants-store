using AutoMapper;
using OnlineStore.DataProvider.Entities;
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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _work = unitOfWork;
            _mapper = mapper;
        }

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
            _work.Dispose();
        }

        public IEnumerable<ProductDTO> Find(Expression<Func<ProductDTO, bool>> predicate)
        {
            var products = _work.Products.GetAll().Select(p => _mapper.Map<ProductDTO>(p)).Where(predicate.Compile());
            return products;
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
