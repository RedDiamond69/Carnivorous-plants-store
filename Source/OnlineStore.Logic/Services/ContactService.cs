using OnlineStore.Logic.Interfaces;
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
        public void Add(ContactDTO model)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ContactDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDTO> Find(System.Linq.Expressions.Expression<Func<ContactDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ContactDTO Get(string guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ContactDTO model)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ContactDTO> models)
        {
            throw new NotImplementedException();
        }

        public void Update(ContactDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
