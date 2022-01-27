using Microsoft.EntityFrameworkCore;
using Poc.Api.Domain.Context;

namespace Poc.Api.Application.Repositories.TodoItem;

public class TodoRepository : IGenericRepository<Domain.Entities.Todos.TodoItem>
{
    private readonly TodoDbContext _ctx;

    public TodoRepository(TodoDbContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<List<Domain.Entities.Todos.TodoItem>> GetAll()
    {
        return await _ctx.Todos!.ToListAsync();
    }

    public async Task<Domain.Entities.Todos.TodoItem> Create(Domain.Entities.Todos.TodoItem t)
    {
        var todo = _ctx.Add(t);
        await _ctx.SaveChangesAsync();

        return todo.Entity;
    }
}