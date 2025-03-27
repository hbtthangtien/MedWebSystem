using Application.Config;
using Application.DTOs.Request;
using Application.DTOs.Response;
using Application.ExceptionCustom;
using Application.Interface;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Persistence.Entities;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly JwtConfig _jwtConfig;
        public AuthenticateService(IAccountRepository accountRepository, IOptions<JwtConfig> jwtConfig)
        {
            _accountRepository = accountRepository;
            _jwtConfig = jwtConfig.Value;

        }
        public async Task<TokenDTO> Authenticate(LoginDTO loginDTO)
        {
            var user = (loginDTO.UsernameOrEmail.Contains('@') == true)
                ? await _accountRepository.UserManager.FindByEmailAsync(loginDTO.UsernameOrEmail) 
                : await _accountRepository.UserManager.FindByNameAsync(loginDTO.UsernameOrEmail)
                ?? throw new LoginException($"Username or email is not existed!!!");
           var login = await _accountRepository.SignInManager.PasswordSignInAsync(user!.UserName!, loginDTO.Password!,false,lockoutOnFailure:false);
           if(!login.Succeeded)
            {
                throw new LoginException("Password is not correct");
            }
            else
            {
                String token = await GenerateToken(user);
                return new TokenDTO
                {
                    Token = token,
                    RefreshToken = ""
                };
            }
            
            
        }
        private async Task<string> GenerateToken(User user)
        {
            var roles = await _accountRepository.UserManager.GetRolesAsync(user);
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName!),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim("ID", user.Id!),
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Token));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (
            issuer: _jwtConfig.ValidIssuer,
                    audience: _jwtConfig.ValidAudience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(_jwtConfig.TokenValidityInMinutes),
                    signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
