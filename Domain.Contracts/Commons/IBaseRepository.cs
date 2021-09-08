using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Contracts.Commons
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
