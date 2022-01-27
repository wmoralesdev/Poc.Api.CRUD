using Microsoft.EntityFrameworkCore;
using Poc.Api.Domain.Entities.Todos;

namespace Poc.Api.Domain.Context;

public class TodoDbContext : DbContext
{
    public DbSet<TodoItem>? Todos { get; set; }

    public TodoDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>()
            .HasKey(ti => ti.Id);
    }
}