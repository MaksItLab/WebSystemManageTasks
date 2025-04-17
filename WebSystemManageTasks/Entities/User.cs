namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Email пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login {  get; set; }

        /// <summary>
        /// Хэш пароля пользователя
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Идентификатор проекта, за которым закреплен пользователь
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Идентификатор роли пользователя
        /// </summary>
        public Guid RoleId { get; set; }

        #region Навигационный свойства
        public Role Role { get; set; }

        public Project Project { get; set; }

        public List<Task> Tasks { get; set; }
        #endregion
    }
}
