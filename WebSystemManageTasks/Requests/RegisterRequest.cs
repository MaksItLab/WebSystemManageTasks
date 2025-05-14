namespace WebSystemManageTasks.Requests
{
    /// <summary>
    /// Запрос для регистрации пользователя
    /// </summary>
    public class RegisterRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; } = default!;

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = default!;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = default!;
    }
}
