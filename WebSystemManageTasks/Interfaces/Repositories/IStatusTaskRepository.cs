using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс для дотсупа к данным статуса задачи
    /// </summary>
    public interface IStatusTaskRepository
    {
        /// <summary>
        /// Добавить статус задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        Task AddAsync(StatusTask status);

        /// <summary>
        /// Удалить статус задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        Task DeleteAsync(StatusTask status);

        /// <summary>
        /// Обновить статус задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        Task UpdateAsync(StatusTask status);
    }
}