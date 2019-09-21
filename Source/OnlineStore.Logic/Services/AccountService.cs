using AutoMapper;
using Microsoft.AspNet.Identity;
using OnlineStore.DataProvider.Entities;
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
        private readonly IMapper _mapper;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _work = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ClaimsIdentity> AuthenticateAsync(ApplicationUserDTO userModel)
        {
            ClaimsIdentity claim = null;
            var user = await _work.Users.FindByEmailAsync(userModel.Email);
            if (user != null)
            {
                if(await _work.Users.CheckPasswordAsync(user, userModel.Password))
                {
                    claim = await _work.Users.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                }
            }
            return claim;
        }

        public async Task<OperationDetails> ConfirmEmailAsync(string guid, string token)
        {
            var result = await _work.Users.ConfirmEmailAsync(guid, token);
            if (result.Succeeded)
            {
                return new OperationDetails(true);
            }
            else
            {
                return new OperationDetails(false);
            }
        }

        public async Task<OperationDetails> CreateAsync(ApplicationUserDTO userModel)
        {
            var user = await _work.Users.FindByEmailAsync(userModel.Email);
            if(user is null)
            {
                user = new ApplicationUser()
                {
                    Email = userModel.Email,
                    LanguageId = userModel.LanguageId,
                    PhoneNumber = userModel.PhoneNumber,
                    UserName = userModel.Email,
                    ApplicationUserProfile = new ApplicationUserProfile()
                    {
                        ImageFilename = userModel.ApplicationUserProfile.ImageFilename,
                        Name = userModel.ApplicationUserProfile.Name,
                        Surname = userModel.ApplicationUserProfile.Surname,
                        Patronymic = userModel.ApplicationUserProfile.Patronymic
                    },
                    Customer = new Customer()
                };
                var result = await _work.Users.CreateAsync(user, userModel.Password);
                if(result.Errors.Count() > 0)
                {
                    return new OperationDetails(false) { Message = result.Errors.FirstOrDefault() };
                }
                await _work.Users.AddToRoleAsync(user.Id, userModel.Role);
                await _work.Complete();
                return new OperationDetails(true);
            }
            else
            {
                return new OperationDetails(false);
            }
        }

        public async Task<OperationDetails> DeleteAsync(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _work.Dispose();
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(string guid)
        {
            var token = await _work.Users.GenerateEmailConfirmationTokenAsync(guid);
            return token;
        }

        public async Task<ApplicationUserDTO> GetAsync(string guid)
        {
            return _mapper.Map<ApplicationUserDTO>(await _work.Users.FindByIdAsync(guid));
        }

        public async Task<ApplicationUserDTO> GetByEmailAsync(string email)
        {
            return _mapper.Map<ApplicationUserDTO>(await _work.Users.FindByEmailAsync(email));
        }

        public async Task<bool> IsEmailConfirmedAsync(string guid)
        {
            return await _work.Users.IsEmailConfirmedAsync(guid);
        }

        public Task SendEmailAsync(string guid, string subject, string body)
        {
            return _work.Users.SendEmailAsync(guid, subject, body);
        }

        public async Task<OperationDetails> UpdateAsync(ApplicationUserDTO userModel)
        {
            throw new NotImplementedException();
        }
    }
}
