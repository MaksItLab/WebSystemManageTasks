namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Сущность, описывающая связь многие-ко-многим между пользователем и задачей
    /// </summary>
    public class UserTask
    {
        /// <summary>
        /// Идентификатор пользователь
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Дата и время назначения пользователя на задачу
        /// </summary>
        public DateTime AssignedAt { get; set; }

        #region Навигационные свойства

        /// <summary>
        /// Пользователь, закрепленный за задачей
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Задача
        /// </summary>
        public ProjectTask Task { get; set; }

        #endregion
    }
}
