namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс роли в приложении
    /// </summary>
    public class Role : BaseEntity
    {
        /// <summary>
        /// Наименование роли
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства

        /// <summary>
        /// Пользователи определенной роли
        /// </summary>
        public List<User>? Users { get; set; }

        #endregion
    }
}
