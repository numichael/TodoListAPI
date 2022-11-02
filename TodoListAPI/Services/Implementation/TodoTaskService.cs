using AutoMapper;
using TodoListAPI.Data.DTOs;
using TodoListAPI.Repositories.Interfaces;
using TodoListAPI.Services.Interfaces;

namespace TodoListAPI.Services.Implementation
{
    public class TodoListService : ITodoTaskService
    {
       
        private readonly IRepositoryWrapper _wrapper;
        private readonly IMapper _mapper;

        public TodoListService(IRepositoryWrapper wrapper, IMapper mapper)
        {
           
            _wrapper = wrapper;
            _mapper = mapper;
        }
        public async Task<List<TodoTaskDto>> GetTodoList()
        
            => _wrapper.TodoTasks.GetAll().Select(x => _mapper.Map<TodoTaskDto>(x)).ToList();
            
        

    }
}
