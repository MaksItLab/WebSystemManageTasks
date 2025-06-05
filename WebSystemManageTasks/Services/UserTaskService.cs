using WebSystemManageTasks.DTOs.UserTask;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Interfaces.Repositories;
using WebSystemManageTasks.Interfaces.Services;

namespace WebSystemManageTasks.Services
{
    /// <summary>
    /// Сервис для получение данных о назначении пользователя на задачу
    /// </summary>
    public class UserTaskService : IUserTaskService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly IUserTaskRepository _userTaskRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="taskRepository">Репозиторий задачи</param>
        /// <param name="userRepository">Репозиторий пользователя</param>
        /// <param name="userTaskRepository">Репозиторий данных о назначении пользователя на задачу</param>
        public UserTaskService(
            ITaskRepository taskRepository, 
            IUserRepository userRepository, 
            IUserTaskRepository userTaskRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
            _userTaskRepository = userTaskRepository;
        }

        /// <summary>
        /// Назначении пользователя на задачу
        /// </summary>
        /// <param name="assignedUser">DTO с данными о назначении пользователя на задачу</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если входные данные равны null</exception>
        /// <exception cref="Exception">Выбрасывается, если пользователь уже назначен на задачу</exception>
        public async Task AddAsync(AssignedUserToTaskDto assignedUser)
        {
            var user = await _userRepository.GetByIdAsync(assignedUser.UserId);

            if (user == null)
                throw new ArgumentNullException($"Пользователя с id {assignedUser.UserId} не существует");

            var task = await _taskRepository.GetTaskByIdAsync(assignedUser.TaskId);

            if (task == null)
                throw new ArgumentNullException($"Задачи с id {assignedUser.TaskId} не существует");

            var alreadyAssigned = await _userTaskRepository.CheckUserToTaskByIdAsync(assignedUser.UserId, assignedUser.TaskId);

            if (alreadyAssigned)
                throw new Exception($"Пользователь с id {assignedUser.UserId} уже назначен на эту задачу с id {assignedUser.TaskId}");

            UserTask userTask = new()
            {
                UserId = assignedUser.UserId,
                TaskId = assignedUser.TaskId,
                AssignedAt = DateTime.Now,
            };

            await _userTaskRepository.AddAsync(userTask);
        }

        /// <summary>
        /// Снимает пользователя с задачи
        /// </summary>
        /// <param name="assignedUser">DTO с данными о назначении пользователя на задачу</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если входные данные равны null</exception>
        /// <exception cref="Exception">Выбрасывается, если пользователь не назначен на задачу</exception>
        public async Task DeleteAsync(AssignedUserToTaskDto assignedUser)
        {
            var user = await _userRepository.GetByIdAsync(assignedUser.UserId);

            if (user == null)
                throw new ArgumentNullException($"Пользователя с id {assignedUser.UserId} не существует");

            var task = await _taskRepository.GetTaskByIdAsync(assignedUser.TaskId);

            if (task == null)
                throw new ArgumentNullException($"Задачи с id {assignedUser.TaskId} не существует");

            var alreadyAssigned = await _userTaskRepository.CheckUserToTaskByIdAsync(assignedUser.UserId, assignedUser.TaskId);

            if (!alreadyAssigned)
                throw new Exception($"Пользователь с id {assignedUser.UserId} не назначен на задачу с id {assignedUser.TaskId}");

            var userTask = await _userTaskRepository.GetUserToTaskByIdAsync(assignedUser.UserId, assignedUser.TaskId);

            await _userTaskRepository.DeleteAsync(userTask);
        }

        /// <summary>
        /// Обновляет информации о назначении пользователя на задачу
        /// </summary>
        /// <param name="assignedUser">DTO с данными о назначении пользователя на задачу</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если входные данные равны null</exception>
        /// <exception cref="Exception">Выбрасывается, если пользователь не назначен на задачу</exception>
        public async Task UpdateAsync(AssignedUserToTaskDto assignedUser)
        {
            var user = await _userRepository.GetByIdAsync(assignedUser.UserId);

            if (user == null)
                throw new ArgumentNullException($"Пользователя с id {assignedUser.UserId} не существует");

            var task = await _taskRepository.GetTaskByIdAsync(assignedUser.TaskId);

            if (task == null)
                throw new ArgumentNullException($"Задачи с id {assignedUser.TaskId} не существует");

            var alreadyAssigned = await _userTaskRepository.CheckUserToTaskByIdAsync(assignedUser.UserId, assignedUser.TaskId);

            if (!alreadyAssigned)
                throw new Exception($"Пользователь с id {assignedUser.UserId} не назначен на задачу с id {assignedUser.TaskId}");

            UserTask userTask = new()
            {
                UserId = assignedUser.UserId,
                TaskId = assignedUser.TaskId,
                AssignedAt = DateTime.Now
            };

            await _userTaskRepository.UpdateAsync(userTask);
        }
    }
}
