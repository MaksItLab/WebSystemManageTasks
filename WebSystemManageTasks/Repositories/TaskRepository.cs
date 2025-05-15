using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий пользователя
    /// </summary>
    public class TaskRepository : ITaskRepository
    {
        /// <summary>
        /// Метод добавления задачи в базу данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public Task AddAsync(ProjectTask task)
        {
            Data.ProjectTasks.Add(task);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод удаления задачи из базы данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public Task DeleteAsync(ProjectTask task)
        {
            Data.ProjectTasks.Remove(task);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод обновления данных о задаче в базе данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public Task UpdateAsync(ProjectTask task)
        {
            var oldTask = Data.ProjectTasks.FirstOrDefault(x => x.Id == task.Id);

            Data.ProjectTasks.Remove(oldTask);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод получения всех задач из базы данных
        /// </summary>
        /// <returns>Перечисление задач</returns>
        public Task<IEnumerable<ProjectTask>> GetAllAsync()
        {
            var tasks = Data.ProjectTasks.Select(x => x);

            return Task.FromResult(tasks);
        }

        /// <summary>
        /// Метод получения задачи по идентификатору из базы данных
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Задача</returns>
        public Task<ProjectTask?> GetTaskById(Guid id)
        {
            var task = Data.ProjectTasks.FirstOrDefault(x => x.Id == id);

            return Task.FromResult(task);
        }
    }
}
