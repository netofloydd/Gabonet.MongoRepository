namespace Gabonet.MongoRepository.Interfaces;

using System.Linq.Expressions;
using Gabonet.MongoRepository.DTOs;
using GasonetAuth.Application.Requests;

public interface IMongoRepository<T> where T : class
{
    Task<T?> GetByIdAsync(object id, List<string>? lookups = null);
    Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<object> ids, List<string>? lookups = null);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> filter);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity, object id);
    Task DeleteAsync(object id);
    Task<PaginatedDataDto<T>> GetPagedAsync(PagedRequest request, List<string>? lookups = null);
}