using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Services
{
    /// <summary>
    /// Интерфейс для генерации Jwt-токена
    /// </summary>
    public interface IJwtProviderService 
    {
        /// <summary>
        /// Генерация Jwt-токена
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns>Jwt-токен</returns>
        string GenerateToken(User user);
    }
}
