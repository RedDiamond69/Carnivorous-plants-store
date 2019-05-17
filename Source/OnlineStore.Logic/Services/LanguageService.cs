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
    public class LanguageService : ILanguageService
    {
        private readonly IUnitOfWork _work;

        public LanguageService(IUnitOfWork unitOfWork)
        {
            _work = unitOfWork;
        }

        public void Add(LanguageDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<LanguageDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<LanguageDTO> Find(Expression<Func<LanguageDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LanguageDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageDTO> GetAll()
        {
            var languages = _work.Languages.GetAll().Select(l => new LanguageDTO()
            {
                LanguageId = l.LanguageId,
                LanguageCode = l.LanguageCode,
                LanguageName = l.LanguageName,
                ImageFilename = l.ImageFilename
            });
            return languages;
        }

        public void Remove(LanguageDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<LanguageDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(LanguageDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
