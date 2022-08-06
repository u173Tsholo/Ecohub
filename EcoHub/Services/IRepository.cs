using System.Linq.Expressions;

namespace EcoHub.Services
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IList<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IList<T> entity);
    }
}
