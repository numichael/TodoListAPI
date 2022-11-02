using TodoListAPI.Data.DTOs;

namespace TodoListAPI.Services.Interfaces
{
    public interface ITodoTaskService
    {
        Task<List<TodoTaskDto>> GetTodoList();
    }
}
