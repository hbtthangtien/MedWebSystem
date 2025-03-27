using Application.Interface;
using Application.Mapper;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependenceInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationMapper));
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            
        }
    }
}
