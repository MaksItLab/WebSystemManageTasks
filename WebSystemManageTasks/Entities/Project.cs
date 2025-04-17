namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс проекта
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства
        public List<Task> Tasks { get; set; }

        public List<User> Users { get; set; }
        #endregion
    }
}
