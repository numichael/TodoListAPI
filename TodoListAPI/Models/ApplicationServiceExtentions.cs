using TodoListAPI.Services.Implementation;
using TodoListAPI.Services.Interfaces;

namespace TodoListAPI.Models
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ITodoTaskService, TodoTaskService>();
            return services;
        }
    }
}
