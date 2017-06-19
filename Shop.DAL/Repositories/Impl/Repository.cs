using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Shop.DAL.Repositories.Impl
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ShopDbContext _db;
        public Repository(ShopDbContext shopDbContext)
        {
            _db = shopDbContext;
        }

        public IEnumerable<TEntity> Find([Optional] Expression<Func<TEntity, bool>> expressionQuery, [Optional] Expression<Func<TEntity, object>> expressionSort, [Optional] int sortType)
        {
            if(expressionQuery!=null && expressionSort!=null)
                return sortType.Equals(2) ? _db.Set<TEntity>().Where(expressionQuery).OrderByDescending(expressionSort) : _db.Set<TEntity>().Where(expressionQuery).OrderBy(expressionSort);
            else
                return _db.Set<TEntity>();
        }
    }
}
