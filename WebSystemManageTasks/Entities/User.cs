namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : BaseEntity
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
        /// Email пользователя
        /// </summary>
        public string Email { get; set; } = default!;

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login {  get; set; } = default!;

        /// <summary>
        /// Хэш пароля пользователя
        /// </summary>
        public string PasswordHash { get; set; } = default!;

        /// <summary>
        /// Идентификатор проекта, за которым закреплен пользователь
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Идентификатор роли пользователя
        /// </summary>
        public Guid RoleId { get; set; }

        #region Навигационный свойства

        /// <summary>
        /// Роль пользователя
        /// </summary>
        public Role? Role { get; set; }

        /// <summary>
        /// Проект, на котором находится пользователь
        /// </summary>
        public Project? Project { get; set; }

        /// <summary>
        /// Задачи, закрепленный за пользователем
        /// </summary>
        public List<Task>? Tasks { get; set; }

        #endregion
    }
}
