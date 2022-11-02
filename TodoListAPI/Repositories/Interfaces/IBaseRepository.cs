using System.Linq.Expressions;

namespace TodoListAPI.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        Task<int> Save();
        void Delete(T entity);
        IEnumerable<T> Filter(Func<T, bool> predicate);
        Task<T> Find(Expression<Func<T, bool>> predicate);
        void CreateRange(List<T> entity);
        void DeleteRange(List<T> entity);
        void UpdateRange(List<T> entity);
        IQueryable<T> Query(Func<T, bool> predicate);

    }
}
