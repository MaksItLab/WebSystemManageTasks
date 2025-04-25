namespace WebSystemManageTasks.Interfaces.Services
{
    /// <summary>
    /// Интерфейс для генерации хэша пароля
    /// </summary>
    public interface IPasswordHasherService
    {
        /// <summary>
        /// Генерация хэша пароля
        /// </summary>
        /// <param name="password">Пароль пользователя</param>
        /// <returns>Хэш пароля</returns>
        string Generate(string password);

        /// <summary>
        /// Сопоставление пароля пользователя и хэша из БД
        /// </summary>
        /// <param name="password"></param>
        /// <param name="hashedPassword"></param>
        /// <returns></returns>
        bool Verify(string password, string hashedPassword);
    }
}
