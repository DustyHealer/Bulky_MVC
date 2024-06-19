using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Category
        // We are not keeping the save changes and update method in the generic repository because it is observed that update method needs some custom logic depending upon the entity which is being updated, and sometimes we only need to update certain fields instead of the whole entity. So we can add those methods directly in the [Entity]Repository class.
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
