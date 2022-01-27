using Poc.Api.Application.Repositories.TodoItem;
using Poc.Api.Application.Services.TodoItemService;

namespace Poc.Api.Core.DI;

public static class DependencyInjection
{
    public static void AddNeededServices(this IServiceCollection services)
    {
        services.AddTransient<TodoItemService>();
        services.AddTransient<TodoRepository>();
    }
}