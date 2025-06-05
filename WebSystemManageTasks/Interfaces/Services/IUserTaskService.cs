using WebSystemManageTasks.DTOs.UserTask;

namespace WebSystemManageTasks.Interfaces.Services
{
    /// <summary>
    /// Интерфейс для доступа к данным связывающей таблицы Users и ProjectTasks
    /// </summary>
    public interface IUserTaskService
    {
        /// <summary>
        /// Добавление записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="assignedUser">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task AddAsync(AssignedUserToTaskDto assignedUser);

        /// <summary>
        /// Удаление записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="assignedUser">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task DeleteAsync(AssignedUserToTaskDto assignedUser);

        /// <summary>
        /// Обновление записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="assignedUser">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task UpdateAsync(AssignedUserToTaskDto assignedUser);
    }
}
