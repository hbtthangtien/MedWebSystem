﻿using Microsoft.Extensions.DependencyInjection;
using Persistence.Interface;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class DependenceInjection
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
        }
    }
}
