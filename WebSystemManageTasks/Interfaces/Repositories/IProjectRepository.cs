using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Interfaces.Repositories
{
    /// <summary>
    /// Интерфейс для доступа к данным проекта
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Метод добавления проекта в базу данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        Task AddProjectAsync(Project project);

        /// <summary>
        /// Метод удаления проекта из базы данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        Task DeleteProjectAsync(Project project);

        /// <summary>
        /// Метод обновления проекта в базе данных
        /// </summary>
        /// <param name="project">Проект</param>
        /// <returns></returns>
        Task UpdateProjectAsync(Project project);

        /// <summary>
        /// Метод получения проекта по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Project?> GetProjectById(Guid id);
    }
}
