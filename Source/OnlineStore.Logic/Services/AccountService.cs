using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Logic.Infrastructure;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _work;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _work = unitOfWork;
        }

        public Task<ClaimsIdentity> Authenticate(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Create(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Delete(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public Task<OperationDetails> Get(string guid)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Update(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }
    }
}
