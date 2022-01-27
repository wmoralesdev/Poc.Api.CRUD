namespace Poc.Api.Application.ViewModels.TodoItem;

public class TodoItemVm
{
    public int Id { get; set; }
    
    public string? ToDo { get; set; }
    
    public DateTime DueDate { get; set; }

    public int Priority { get; set; }

    public bool Completed { get; set; }
}