using TodoListAPI.Models;

namespace TodoListAPI.Repositories.Interfaces
{
    public interface IRepositoryWrapper : IBaseRepository<TodoTask>
    {
        ITodoTaskRepository TodoTasks { get; }
    }
}
