using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Providers;
using WebSystemManageTasks.Interfaces.Repositories;
using WebSystemManageTasks.Interfaces.Services;

namespace WebSystemManageTasks.Services
{
    /// <summary>
    /// Сервис идентификации пользователя
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly IPasswordHasherService _passwordHasher;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="passwordHasher">Сервис генерации хэша пароля</param>
        /// <param name="jwtProvider">Сервис генерации Jwt-токена</param>
        public AuthService(
            IPasswordHasherService passwordHasher, 
            IJwtProvider jwtProvider,
            IUserRepository userRepository)
        {
            _passwordHasher = passwordHasher;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Метод идентификации существущего пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Jwt-токен</returns>
        public async Task<string> LoginAsync(string login, string password)
        {
            string token = "Not Authenticated";

            if (login == null) 
                throw new ArgumentNullException("Введите логин");

            if (password == null) 
                throw new ArgumentNullException("Введите пароль");

            var user = await _userRepository.ExistsByLoginAsync(login);

            if (user == null) 
                throw new ArgumentException("Пользователь не существует");

            if (!_passwordHasher.Verify(password, user.PasswordHash))
                throw new ArgumentException("Неверный пароль");

            token = _jwtProvider.GenerateToken(user);

            return token;
        }

        /// <summary>
        /// Метод для регистрации нового пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="email">Почта</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <returns>Jwt-токен</returns>
        public async Task<string> RegisterAsync(string login, string password, string email, string name, string surname)
        {
            string token = "Not Authenticated";

            if (login == null || password == null || email == null || name == null || surname == null) 
                throw new ArgumentNullException("Введите данные");

            var user = await _userRepository.ExistsByLoginAsync(login);

            if (user != null)
                throw new Exception("Пользователь с таким логином уже существует");

            var hashedPassword = _passwordHasher.Generate(password);

            User newUser = new User
            {
                Login = login,
                PasswordHash = hashedPassword,
                Email = email,
                Name = name,
                Surname = surname
            };

            await _userRepository.AddAsync(newUser);

            token = _jwtProvider.GenerateToken(newUser);

            return token;
        }
    }
}
