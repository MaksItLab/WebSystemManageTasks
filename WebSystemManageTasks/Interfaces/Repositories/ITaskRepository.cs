using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс для доступа к данным задачи
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Метод добавления задачи в базу данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        Task AddAsync(ProjectTask task);

        /// <summary>
        /// Метод обновления данных о задаче в базе данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        Task UpdateAsync(ProjectTask task);

        /// <summary>
        /// Метод удаления задачи
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        Task DeleteAsync(ProjectTask task);

        /// <summary>
        /// Метод получения всех задач
        /// </summary>
        /// <returns>Перечисление задач</returns>
        Task<IEnumerable<ProjectTask>> GetAllAsync();

        /// <summary>
        /// Метод получения задачи по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор задачи</param>
        /// <returns>Задача</returns>
        Task<ProjectTask?> GetTaskById(Guid id);
    }
}
