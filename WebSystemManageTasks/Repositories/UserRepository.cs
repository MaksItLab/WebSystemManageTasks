using Microsoft.EntityFrameworkCore;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий для работы с пользователями
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Метод добавления пользователя в базу данных
        /// </summary>
        /// <param name="user">Пользователь</param>
        /// <returns></returns>
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод удаления пользователя из базы данных
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns></returns>
        public async Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод для обновления данных пользователя
        /// </summary>
        /// <param name="user">Пользователь с новыми данными</param>
        /// <returns></returns>
        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод получения всех пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        /// <summary>
        /// Метод возвращает пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <returns>Пользователь</returns>
        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }

        /// <summary>
        /// Метод получения пользователя по почте
        /// </summary>
        /// <param name="email">Почта</param>
        /// <returns>Пользователь</returns>
        public async Task<User?> GetByEmailAsync(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }

        /// <summary>
        /// Метод получения пользователя по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>Пользователь</returns>
        public async Task<User?> ExistsByLoginAsync(string login)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == login);
            return user;
        }
    }
}
