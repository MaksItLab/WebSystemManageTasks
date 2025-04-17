namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс статуса задачи
    /// </summary>
    public class StatusTask : BaseEntity
    {
        /// <summary>
        /// Название статуса задачи
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства

        /// <summary>
        /// Задачи определенного статуса
        /// </summary>
        public List<Task>? Tasks { get; set; }

        #endregion
    }
}
