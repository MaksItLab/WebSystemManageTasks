namespace WebSystemManageTasks.Entities
{
    /// <summary>
    /// Класс роли в приложении
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование роли
        /// </summary>
        public string Name { get; set; }

        #region Навигационные свойства
        public List<User> Users { get; set; }

        public List<RolePrivileges> Privileges { get; set; }
        #endregion
    }
}
