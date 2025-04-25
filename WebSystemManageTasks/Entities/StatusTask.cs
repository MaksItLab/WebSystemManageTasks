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
        public string Name { get; set; } = default!;

        #region Навигационные свойства

        /// <summary>
        /// Задачи определенного статуса
        /// </summary>
        public List<ProjectTask>? Tasks { get; set; }

        #endregion
    }
}
