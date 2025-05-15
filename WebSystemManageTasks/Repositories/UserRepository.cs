using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий для работы с пользователями
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Метод добавления пользователя в базу данных
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        public Task AddAsync(User user)
        {
            Data.Users.Add(user);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод удаления пользователя из базы данных
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns></returns>
        public Task DeleteAsync(Guid id)
        {
            var user = Data.Users.Find(x => x.Id == id);

            if (user != null)
            {
                Data.Users.Remove(user);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод для обновления данных пользователя
        /// </summary>
        /// <param name="user">Пользователь с новыми данными</param>
        /// <returns></returns>
        public Task UpdateAsync(User user)
        {
            var oldUser = Data.Users.Find(x => x.Id == user.Id);

            if (oldUser != null)
            {
                Data.Users.Remove(oldUser);
                Data.Users.Add(user);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Метод получения всех пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        public Task<IEnumerable<User>> GetAllAsync()
        {
            var users = Data.Users.Select(x => x);
            return Task.FromResult(users);
        }

        /// <summary>
        /// Метод возвращает пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns>Пользователь</returns>
        public Task<User?> GetByIdAsync(Guid id)
        {
            var user = Data.Users.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(user);
        }

        /// <summary>
        /// Метод получения пользователя по почте
        /// </summary>
        /// <param name="email">Почта</param>
        /// <returns>Пользователь</returns>
        public Task<User?> GetByEmailAsync(string email)
        {
            var user = Data.Users.FirstOrDefault(x => x.Email == email);
            return Task.FromResult(user);
        }

        /// <summary>
        /// Метод получения пользователя по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>Пользователь</returns>
        public Task<User?> ExistsByLoginAsync(string login)
        {
            var user = Data.Users.FirstOrDefault(x => x.Login == login);
            return Task.FromResult(user);
        }
    }
}
