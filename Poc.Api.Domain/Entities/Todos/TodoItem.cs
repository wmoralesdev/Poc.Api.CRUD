namespace Poc.Api.Domain.Entities.Todos;

public class TodoItem
{
    public int Id { get; set; }
    
    public string? ToDo { get; set; }
    
    public DateTime DueDate { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public int Priority { get; set; }

    public bool Completed { get; set; }
}