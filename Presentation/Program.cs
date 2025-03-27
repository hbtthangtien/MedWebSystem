using Application;
using Application.Config;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Persistence;
using Persistence.Config;
using Presentation.Middleware;
using System.Text;
namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            });
           
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddIdentity();
            builder.Services.AddDBContext(builder.Configuration);
            builder.Services.AddApplication();
            builder.Services.AddPersistence();
            var JwtConf = builder.Configuration.GetSection("JwtConfig");
            builder.Services.Configure<JwtConfig>(JwtConf);
            var jwt = JwtConf.Get<JwtConfig>();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    var key = Encoding.UTF8.GetBytes(jwt!.Token);
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = jwt.ValidateIssuer,
                        ValidIssuer = jwt.ValidIssuer,
                        ValidateAudience = jwt.ValidateAudience,
                        ValidAudience = jwt.ValidAudience,
                        ValidateLifetime = jwt.ValidateLifetime,
                        ClockSkew = TimeSpan.Zero,
                        ValidateIssuerSigningKey = jwt.ValidateIssuerSigningKey,
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseMiddleware<ExceptionGlobal>();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
