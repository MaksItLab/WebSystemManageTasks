using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;
using WebSystemManageTasks.Providers.JwtToken;

namespace WebSystemManageTasks.Extensions
{
    /// <summary>
    /// Статический класс расширения для аутентификации
    /// </summary>
    public static class AddAuthentificationExtensions
    {
        /// <summary>
        /// Статический метод расширения, настраивающий аутентификацию
        /// </summary>
        /// <param name="services"></param>
        /// <param name="jwtOptions"></param>
        public static void AddJwtAuthentication(
            this IServiceCollection services,
            IOptions<JwtOptions> jwtOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(jwtOptions.Value.SecretKey))
                    };

                    options.Events = new JwtBearerEvents()
                    {
                        OnMessageReceived = context =>
                        {
                            context.Token = context.Request.Cookies["token"];

                            return Task.CompletedTask;
                        }
                    };
                });


            
        }
    }
}
