using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Find([Optional] Expression<Func<TEntity, bool>> expressionQuery, [Optional] Expression<Func<TEntity, object>> expressionSort, [Optional] int sortType);
    }
}
