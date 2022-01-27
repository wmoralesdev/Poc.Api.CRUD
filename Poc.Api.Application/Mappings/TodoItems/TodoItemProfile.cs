using AutoMapper;
using Poc.Api.Application.ViewModels.TodoItem;
using Poc.Api.Domain.Entities.Todos;

namespace Poc.Api.Application.Mappings.TodoItems;

public class TodoItemProfile : Profile
{
    public TodoItemProfile()
    {
        CreateMap<TodoItem, TodoItemVm>();
        CreateMap<TodoItemVm, TodoItem>();

        CreateMap<CreateTodoItemVm, TodoItem>();
    }
}