using AutoMapper;
using TodoListAPI.Data.DTOs;
using TodoListAPI.Models;

namespace TodoListAPI.AutoMapper
{
    public class DtoToDomainProfile : Profile
    {
        public DtoToDomainProfile()
        {
            CreateMap<TodoTaskDto, TodoTask>();
        }
    }
}
