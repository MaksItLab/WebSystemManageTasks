using WebSystemManageTasks.Interfaces.Services;

namespace WebSystemManageTasks.Services
{
    /// <summary>
    /// Сервис для генерации хэша пароля
    /// </summary>
    public class PasswordHasherService : IPasswordHasherService
    {
        /// <summary>
        /// Генерация хэша пароля
        /// </summary>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>Хэш пароля</returns>
        public string Generate(string password) => 
            BCrypt.Net.BCrypt.EnhancedHashPassword(password);

        /// <summary>
        /// Проверка на соответствие пароля пользователя и хэша в БД
        /// </summary>
        /// <param name="password">Пароль пользователя</param>
        /// <param name="hashedPassword">Хэш пароля пользователя в БД</param>
        /// <returns>true, если соответствие есть - false, если соответствие отсутствует</returns>
        public bool Verify(string password, string hashedPassword) =>
            BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
    }
}
