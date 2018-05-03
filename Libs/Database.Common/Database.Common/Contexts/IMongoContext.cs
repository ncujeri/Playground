using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database.Common.Contexts
{
    public interface IMongoContext<T> : IDisposable
        
    {
        Task Add(T entity);
        Task DeleteWhere(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSingle(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> where);
    }
}
