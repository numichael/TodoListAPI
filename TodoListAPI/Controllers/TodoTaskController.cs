using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoListAPI.Services.Interfaces;

namespace TodoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoTaskController : ControllerBase
    {
        private readonly ITodoTaskService _todoTaskService;
        private readonly ILogger<TodoTaskController> _logger;

        public TodoTaskController(ITodoTaskService todoTaskService, ILogger<TodoTaskController> logger)
        {
            _todoTaskService = todoTaskService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult>GetToDoList()
        {
            _logger.LogInformation("Retrieving Todo List");
            return Ok(_todoTaskService.GetTodoList());
        }
    }
}
