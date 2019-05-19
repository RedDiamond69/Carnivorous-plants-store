using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Model.DTO;
using OnlineStore.Model.BusinessObjects;
using OnlineStore.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace OnlineStore.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _work = unitOfWork;
            _mapper = mapper;
        }

        public void Add(CategoryDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CategoryDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<CategoryDTO> Find(Expression<Func<CategoryDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            var categories = _work.Categories.GetAll().Select(c => _mapper.Map<CategoryDTO>(c));
            return categories;
        }

        public void Remove(CategoryDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<CategoryDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
