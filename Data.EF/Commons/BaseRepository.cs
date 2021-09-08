using Domain.Contracts.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.EF.Common
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected InfluencerDbContext _ctx { get; set; }
        public BaseRepository(InfluencerDbContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<T> FindAll()
        {
            return _ctx.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _ctx.Set<T>().Where(expression).AsNoTracking();
        }
        public async Task<T> Create(T entity)
        {
            _ctx.Set<T>().Add(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }
    }
}
