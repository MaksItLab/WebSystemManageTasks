using WebSystemManageTasks.DTOs.UserTask;
using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс репозитория для получения данных о таблице, связывающей таблицы User и Task
    /// </summary>
    public interface IUserTaskRepository
    {
        /// <summary>
        /// Метод добавления записи в связывающую таблицу
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task AddAsync(UserTask userTask);

        /// <summary>
        /// Метод обновления записи в связывающей таблице
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task UpdateAsync(UserTask userTask);

        /// <summary>
        /// Метод удаления записи в связывающей таблице
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        Task DeleteAsync(UserTask userTask);

        /// <summary>
        /// Метод проверки существования записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="UserId">Идентификатор пользователя</param>
        /// <param name="TaskId">Идентификатор задачи</param>
        /// <returns>true, если данные о назначении существуют - false, если данные о назначении не существуют</returns>
        Task<bool> CheckUserToTaskByIdAsync(Guid UserId, Guid TaskId);


        /// <summary>
        /// Метод получения данных записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="UserId">Идентификатор пользователя</param>
        /// <param name="TaskId">Идентификатор задачи</param>
        /// <returns></returns>
        Task<UserTask?> GetUserToTaskByIdAsync(Guid UserId, Guid TaskId);
        
    }
}
