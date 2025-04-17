namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс задачи
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Время окончания задачи
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// Идентификатор статуса задачи
        /// </summary>
        public Guid StatusId { get; set; }

        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid UserId { get; set; }

        #region Навигационные свойства
        public StatusTask Status { get; set; }

        public Project Project { get; set; }

        public User User { get; set; }
        #endregion
    }
}
