namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс задачи
    /// </summary>
    public class Task : BaseEntity
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string? Description { get; set; }

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
        public Guid? UserId { get; set; }

        /// <summary>
        /// Номер задачи в секции
        /// </summary>
        public int Order { get; set; }

        #region Навигационные свойства

        /// <summary>
        /// Статус задачи
        /// </summary>
        public StatusTask? Status { get; set; }

        /// <summary>
        /// Проект, в котором находится задача
        /// </summary>
        public Project? Project { get; set; }

        /// <summary>
        /// Пользователь, закрепленный за задачей
        /// </summary>
        public User? User { get; set; }

        #endregion
    }
}
