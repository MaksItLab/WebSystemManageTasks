using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Services;

namespace WebSystemManageTasks.JwtProvider
{
    /// <summary>
    /// Сервис для генерации Jwt-токена
    /// </summary>
    public class JwtProviderService : IJwtProviderService
    {
        private readonly JwtOptions _jwtOptions;

        public JwtProviderService(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        /// <summary>
        /// Генерация Jwt-токена
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Jwt-токен</returns>
        public string GenerateToken(User user)
        {
            string secretKey = "This is secret key, secret key 123!@#$%^&*()_+";
            int expiresHours = 3;

            Claim[] claims = [new("userId", user.Id.ToString())];

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddHours(_jwtOptions.ExpiresHours));

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;
        }
    }
}
