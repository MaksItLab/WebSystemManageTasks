using Microsoft.EntityFrameworkCore;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий UserTask
    /// </summary>
    public class UserTaskRepository : IUserTaskRepository
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст БД</param>
        public UserTaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Метод добавления данных о назначении пользователя на задачу в базу данных
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        public async Task AddAsync(UserTask userTask)
        {
            await _context.UsersTasks.AddAsync(userTask);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод удаления данных о назначении пользователя на задачу в базе данных
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        public async Task DeleteAsync(UserTask userTask)
        {
           _context.UsersTasks.Remove(userTask);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод обновления данных о назначении пользователя на задачу в базе данных
        /// </summary>
        /// <param name="userTask">Данные о назначении пользователя на задачу</param>
        /// <returns></returns>
        public async Task UpdateAsync(UserTask userTask)
        {
            _context.UsersTasks.Update(userTask);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод получения записи о назначении пользователя на задачу
        /// </summary>
        /// <param name="UserId">Идентификатор пользователя</param>
        /// <param name="TaskId">Идентификатор задачи</param>
        /// <returns>true, если данные о назначении существуют - false, если данные о назначении не существуют</returns>
        public async Task<bool> CheckUserToTaskByIdAsync(Guid UserId, Guid TaskId)
        {
            var alreadyAssigned = await _context.UsersTasks.AnyAsync(x => x.TaskId == TaskId && x.UserId == UserId);

            return alreadyAssigned;
        }

        public async Task<UserTask?> GetUserToTaskByIdAsync(Guid UserId, Guid TaskId)
        {
            var userTask = await _context.UsersTasks.FirstOrDefaultAsync(x => x.UserId == UserId && x.TaskId == TaskId);

            return userTask;
        }
    }
}
