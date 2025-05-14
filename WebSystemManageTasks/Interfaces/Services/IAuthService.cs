namespace WebSystemManageTasks.Interfaces.Services
{
    /// <summary>
    /// Интерфейс идентификации пользователя
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Метод для идентификации существующего пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        Task<string> LoginAsync(string login, string password);

        /// <summary>
        /// Метод для регистрации нового пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="email">Почта</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <returns></returns>
        Task<string> RegisterAsync(string login, string password, string email, string name, string surname);
    }
}
