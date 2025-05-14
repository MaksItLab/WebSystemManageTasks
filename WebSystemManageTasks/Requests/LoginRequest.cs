namespace WebSystemManageTasks.Requests
{
    /// <summary>
    /// Запрос для аутентификации
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; } = default!;

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; } = default!;
    }
}
