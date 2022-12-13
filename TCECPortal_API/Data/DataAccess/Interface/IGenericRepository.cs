using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TCECPortal_API.Data.DataAccess.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(T t);
        Task<T> AddAsync(T t);
        int Count();
        Task<int> CountAsync();
        void Delete(T entity);
        Task<int> DeleteAsyn(T entity);
        Task<int> DeleteRangeAsync(IEnumerable<T> entity);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsyn();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetWithInclude(Expression<Func<T, bool>> predicate, params string[] include);
        IQueryable<T> GetWithInclude(params string[] include);
        Task<T> GetAsync(object id);
        void Save();
        Task<int> SaveAsync();
        T Update(T t, object key);
        Task<T> UpdateAsync(T t, object key);
    }
}
