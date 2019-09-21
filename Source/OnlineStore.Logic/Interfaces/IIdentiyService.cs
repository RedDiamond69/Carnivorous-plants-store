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
        Task<OperationDetails> CreateAsync(TUserModel userModel);
        Task<OperationDetails> DeleteAsync(TUserModel userModel);
        Task<TUserModel> GetAsync(string guid);
        Task<TUserModel> GetByEmailAsync(string email);
        Task<bool> IsEmailConfirmedAsync(string guid);
        Task<string> GenerateEmailConfirmationTokenAsync(string guid);
        Task SendEmailAsync(string guid, string subject, string body);
        Task<OperationDetails> ConfirmEmailAsync(string guid, string token);
        Task<OperationDetails> UpdateAsync(TUserModel userModel);
        Task<ClaimsIdentity> AuthenticateAsync(TUserModel userModel);
    }
}
