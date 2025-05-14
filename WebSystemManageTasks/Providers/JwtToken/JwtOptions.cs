namespace WebSystemManageTasks.Providers.JwtToken
{
    /// <summary>
    /// Модель настроек Jwt-токена
    /// </summary>
    public class JwtOptions
    {
        /// <summary>
        /// Секретный ключ
        /// </summary>
        public string SecretKey { get; set; } = string.Empty;

        /// <summary>
        /// Время существования токена
        /// </summary>
        public int ExpiresHours { get; set; }
    }
}
