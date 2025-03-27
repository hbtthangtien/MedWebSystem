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
            services.AddIdentity<User,IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;

                options.User.RequireUniqueEmail = true;
                
            })
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
