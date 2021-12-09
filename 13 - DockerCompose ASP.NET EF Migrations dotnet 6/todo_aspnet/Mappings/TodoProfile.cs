using aspnet.dto;
using aspnet.Models;
using AutoMapper;

namespace aspnet.Mappings
{
    public class TodoProfile:Profile
    {

        public TodoProfile()
        {
            CreateMap<Todo, TodoReadDto>();
            CreateMap<TodoWriteDto, Todo>();
            CreateMap<TodoUpdateDto, Todo>();
        }
        
    }
}