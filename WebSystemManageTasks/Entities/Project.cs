namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс проекта
    /// </summary>
    public class Project : BaseEntity
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства

        /// <summary>
        /// Задачи проекта
        /// </summary>
        public List<Task>? Tasks { get; set; }

        /// <summary>
        /// Пользователи, находящиеся на проекте
        /// </summary>
        public List<User> Users { get; set; }

        #endregion
    }
}
