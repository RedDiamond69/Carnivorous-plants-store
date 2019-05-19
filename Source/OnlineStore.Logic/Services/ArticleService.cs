using AutoMapper;
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
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _work = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ArticleDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ArticleDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<ArticleDTO> Find(Expression<Func<ArticleDTO, bool>> predicate)
        {
            var articles = _work.Articles.GetAll().Select(p => _mapper.Map<ArticleDTO>(p)).Where(predicate.Compile());
            return articles;
        }

        public ArticleDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArticleDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ArticleDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ArticleDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(ArticleDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
