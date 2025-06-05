using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий для получения данных о статусе
    /// </summary>
    public class StatusTaskRepository : IStatusTaskRepository
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public StatusTaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавление статуса задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        public async Task AddAsync(StatusTask status)
        {
            await _context.StatusTasks.AddAsync(status);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Удаление статуса задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        public async Task DeleteAsync(StatusTask status)
        {
            _context.StatusTasks.Remove(status);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Обновление статуса задачи
        /// </summary>
        /// <param name="status">Статус задачи</param>
        /// <returns></returns>
        public async Task UpdateAsync(StatusTask status)
        {
            _context.StatusTasks.Update(status);

            await _context.SaveChangesAsync();
        }
    }
}