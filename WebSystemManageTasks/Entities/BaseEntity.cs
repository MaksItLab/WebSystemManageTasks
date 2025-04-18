namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Время обновления
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
