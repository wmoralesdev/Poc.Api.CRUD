namespace Poc.Api.Application.ViewModels.TodoItem;

public record CreateTodoItemVm(string ToDo, DateTime DueDate, bool Completed, int Priority = 1);