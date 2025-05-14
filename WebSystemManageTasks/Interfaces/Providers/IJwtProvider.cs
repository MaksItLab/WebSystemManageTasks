using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Providers
{
    /// <summary>
    /// Интерфейс для генерации Jwt-токена
    /// </summary>
    public interface IJwtProvider
    {
        /// <summary>
        /// Генерация Jwt-токена
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Jwt-токен</returns>
        string GenerateToken(User user);
    }
}
