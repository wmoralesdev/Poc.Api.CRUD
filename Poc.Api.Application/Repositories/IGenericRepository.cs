namespace Poc.Api.Application.Repositories;

public interface IGenericRepository<T>
{
    Task<List<T>> GetAll();

    Task<T> Create(T t);
}