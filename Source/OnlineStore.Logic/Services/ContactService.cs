using AutoMapper;
using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Model.BusinessObjects;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Services
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;

        public ContactService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _work = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ShopContactDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ShopContactDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public IEnumerable<ShopContactDTO> Find(System.Linq.Expressions.Expression<Func<ShopContactDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ShopContactDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShopContactDTO> GetAll()
        {
            var contacts = _work.ShopContact.GetAll().Select(c => new ShopContactBL(c).GetDTO());
            return contacts;
        }

        public void Remove(ShopContactDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ShopContactDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(ShopContactDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
