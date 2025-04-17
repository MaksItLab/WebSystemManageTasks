namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс статуса задачи
    /// </summary>
    public class StatusTask
    {
        /// <summary>
        /// Идентификатор статуса задачи
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название статуса задачи
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства
        public List<Task> Tasks { get; set; }
        #endregion
    }
}
