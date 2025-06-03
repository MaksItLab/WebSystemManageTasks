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
        Task AddAsync(User user);

        /// <summary>
        /// Метод обновления данных пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        Task UpdateAsync(User user);

        /// <summary>
        /// Метод для удаления пользователя
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        Task DeleteAsync(User user);

        /// <summary>
        /// Метод получения пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Пользователь</returns>
        Task<User?> GetByIdAsync(Guid id);

        /// <summary>
        /// Метод получения пользователя по почте
        /// </summary>
        /// <param name="email">Почта</param>
        /// <returns>Пользователь</returns>
        Task<User?> GetByEmailAsync(string email);

        /// <summary>
        /// Метод получения всех пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        Task<IEnumerable<User>> GetAllAsync();

        /// <summary>
        /// Проверка на существование пользователя с переданным логином
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>Пользователь</returns>
        Task<User?> ExistsByLoginAsync(string login);
    }
}
