using TodoListAPI.Data;
using TodoListAPI.Models;
using TodoListAPI.Repositories.Interfaces;

namespace TodoListAPI.Repositories.Implementation
{
    public class TodoTaskRepository: BaseRepository<TodoTask>, ITodoTaskRepository
    {
        public TodoTaskRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
