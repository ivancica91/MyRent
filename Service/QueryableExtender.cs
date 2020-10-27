using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace My_Rent.Service
{
    public static class QueryableExtender
    {
        public static IQueryable<TEntity> WhereIf<TEntity>(
            this IQueryable<TEntity> query,
            bool condition,
            Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return condition ? query.Where(predicate) : query;
        }
    }
}
