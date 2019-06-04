using OnlineStore.Logic.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.Interfaces
{
    public interface IIdentiyService<TUserModel> : IDisposable where TUserModel : class
    {
        Task<OperationDetails> Create(TUserModel userModel);
        Task<OperationDetails> Delete(TUserModel userModel);
        Task<OperationDetails> Get(string guid);
        Task<OperationDetails> Update(TUserModel userModel);
        Task<ClaimsIdentity> Authenticate(TUserModel userModel);
    }
}
