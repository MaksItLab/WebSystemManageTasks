using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Repositories;

namespace WebSystemManageTasks.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public Task AddAsync(ProjectTask task)
        {
            Data.ProjectTasks.Add(task);

            return Task.CompletedTask;
        }

        public Task DeleteAsync(ProjectTask task)
        {
            Data.ProjectTasks.Remove(task);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(ProjectTask task)
        {
            var oldTask = Data.ProjectTasks.FirstOrDefault(x => x.Id == task.Id);

            Data.ProjectTasks.Remove(oldTask);

            return Task.CompletedTask;
        }

        public Task<IEnumerable<ProjectTask>> GetAllAsync()
        {
            var tasks = Data.ProjectTasks.Select(x => x);

            return Task.FromResult(tasks);
        }

        public Task<ProjectTask?> GetTaskById(Guid id)
        {
            var task = Data.ProjectTasks.FirstOrDefault(x => x.Id == id);

            return Task.FromResult(task);
        }
    }
}
