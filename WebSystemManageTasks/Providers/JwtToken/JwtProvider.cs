using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Providers;

namespace WebSystemManageTasks.Providers.JwtToken
{
    /// <summary>
    /// Провайдер для генерации Jwt-токена
    /// </summary>
    public class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _jwtOptions;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="jwtOptions"></param>
        public JwtProvider(IOptions<JwtOptions> jwtOptions)
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
