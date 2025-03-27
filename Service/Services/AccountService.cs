using Application.DTOs.Request;
using Application.ExceptionCustom;
using Application.Interface;
using AutoMapper;
using Persistence.Constants;
using Persistence.Entities;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }
        public async Task CreateAccount(RegisterDTO dto)
        {
            var user = new User
            {
                UserName = dto.Username,
                Email = dto.Email,
            };
            var signUp =await _accountRepository.UserManager.CreateAsync(user,dto.Password!);
            var addRole = await _accountRepository.UserManager.AddToRoleAsync(user, UserRole.PATIENT);
            if(!signUp.Succeeded)
            {
                throw new RegisterException(signUp.Errors);
            }
            if(!addRole.Succeeded)
            {
                throw new RegisterException(addRole.Errors);
            }
        }
    }
}
