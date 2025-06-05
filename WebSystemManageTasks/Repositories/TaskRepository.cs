using Microsoft.EntityFrameworkCore;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий задачи
    /// </summary>
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекс БД</param>
        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Метод добавления задачи в базу данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public async Task AddAsync(ProjectTask task)
        {
            await _context.ProjectsTasks.AddAsync(task);
        }

        /// <summary>
        /// Метод удаления задачи из базы данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public async Task DeleteAsync(ProjectTask task)
        {
            _context.ProjectsTasks.Remove(task);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод обновления данных о задаче в базе данных
        /// </summary>
        /// <param name="task">Задача</param>
        /// <returns></returns>
        public async Task UpdateAsync(ProjectTask task)
        {
            _context.ProjectsTasks.Update(task);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод получения всех задач из базы данных
        /// </summary>
        /// <returns>Перечисление задач</returns>
        public async Task<IEnumerable<ProjectTask>> GetAllAsync()
        {
            var tasks = await _context.ProjectsTasks.ToListAsync();
            return tasks;
        }

        /// <summary>
        /// Метод получения задачи по идентификатору из базы данных
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Задача</returns>
        public async Task<ProjectTask?> GetTaskByIdAsync(Guid id)
        {
            var task = await _context.ProjectsTasks.FindAsync(id);

            return task;
        }
    }
}
