namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс привилегии
    /// </summary>
    public class RolePrivileges
    {
        /// <summary>
        /// Идентификатор привилегии
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Номер привилегии
        /// </summary>
        public int Privilege { get; set; }

        #region Навигационные свойства
        public Role Role { get; set; }
        #endregion
    }
}
