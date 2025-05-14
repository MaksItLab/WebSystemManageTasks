using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс для доступа к данным пользователя
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Метод добавления нового пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        Task AddUserAsync(User user);
    }
}
