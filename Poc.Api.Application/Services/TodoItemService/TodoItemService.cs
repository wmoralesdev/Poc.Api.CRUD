using AutoMapper;
using Poc.Api.Application.Repositories.TodoItem;
using Poc.Api.Application.ViewModels.TodoItem;
using Poc.Api.Domain.Entities.Todos;

namespace Poc.Api.Application.Services.TodoItemService;

public class TodoItemService
{
    private readonly TodoRepository _repo;
    private readonly IMapper _mapper;

    public TodoItemService(TodoRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<List<TodoItemVm>> GetAll()
    {
        var todos = await _repo.GetAll();

        return _mapper.Map<List<TodoItem>, List<TodoItemVm>>(todos);
    }

    public async Task<TodoItemVm> Create(CreateTodoItemVm vm)
    {
        var todo = _mapper.Map<CreateTodoItemVm, TodoItem>(vm);

        var result = _mapper.Map<TodoItem, TodoItemVm>(
            await _repo.Create(todo)
        );

        return result;
    }
}