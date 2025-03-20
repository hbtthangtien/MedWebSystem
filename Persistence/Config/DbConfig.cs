using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Persistence.Config
{
    public static class DbConfig
    {
        public static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User,IdentityRole>()
                .AddEntityFrameworkStores<MedSystemContext>()
                .AddDefaultTokenProviders();
        }
        public static void AddDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MedSystemContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyDatabase"));
            });

        }
    }
}
