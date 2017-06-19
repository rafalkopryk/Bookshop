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

        public virtual IEnumerable<TEntity> Find(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Expression<Func<TEntity, bool>> filter = null          
        ){
            IQueryable<TEntity> query = _db.Set<TEntity>().AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
    }
}
