using AutoMapper;
using TodoListAPI.Data.DTOs;
using TodoListAPI.Models;

namespace TodoListAPI.AutoMapper
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<TodoTask, TodoTaskDto>();
        }
    }
}
