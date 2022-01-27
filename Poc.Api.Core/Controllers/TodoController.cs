using Microsoft.AspNetCore.Mvc;
using Poc.Api.Application.Services.TodoItemService;
using Poc.Api.Application.ViewModels.TodoItem;

namespace Poc.Api.Core.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoItemService _service;

    public TodoController(TodoItemService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<TodoItemVm>>> GetAllTodos()
    {
        return await _service.GetAll();
    }

    [HttpPost("new")]
    public async Task<ActionResult<TodoItemVm>> CreateTodo(CreateTodoItemVm vm)
    {
        return await _service.Create(vm);
    }
}