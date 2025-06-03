using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    /// <summary>
    /// Репозиторий проекта
    /// </summary>
    public class ProjectRepository : IProjectRepository
    {
        /// <summary>
        /// Поле контекста базы данных
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Метод добавления проекта в базу данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        public async Task AddProjectAsync(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод удаления проекта из базы данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        public async Task DeleteProjectAsync(Project project)
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод обновления проекта в базе данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        public async Task UpdateProjectAsync(Project project)
        {
            _context.Projects.Update(project);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Метод получения проекта по идентифкатору
        /// </summary>
        /// <param name="id">Иентификатор проекта</param>
        /// <returns></returns>
        public async Task<Project?> GetProjectById(Guid id)
        {
            var user = await _context.Projects.FindAsync(id);

            return user;
        }
    }
}
