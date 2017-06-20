using Shop.DAL.Models;
using Shop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Shop.Web.Tests.FakeRepositories
{
    class RepositoryFake<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IEnumerable<TEntity> _items;
        public RepositoryFake(IEnumerable<TEntity> items)
        {
            _items = items;
        }

        public IEnumerable<TEntity> Find(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _items.AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
    }
}
