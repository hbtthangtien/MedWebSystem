using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        public Task<T> GetSingleTon(Expression<Func<T, bool>> predicate);

        public Task AddAsync(T entity);

        public Task UpdateAsync(T entity);

        public Task DeleteAsync(T entity);
    }
}
