using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities;

namespace DataAccess.Concrete
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        T GetWithOneIncludes<TPropertyOne>(Expression<Func<T, bool>> filter, Expression<Func<T, TPropertyOne>> includeOne);
        T GetWithTwoIncludes<TPropertyOne, TPropertyTwo>(Expression<Func<T, bool>> filter, Expression<Func<T, TPropertyOne>> includeOne, Expression<Func<T, TPropertyTwo>> includeTwo);
        T GetWithThreeIncludes<TPropertyOne, TPropertyTwo, TPropertyThree>(Expression<Func<T, bool>> filter, Expression<Func<T, TPropertyOne>> includeOne, Expression<Func<T, TPropertyTwo>> includeTwo, Expression<Func<T, TPropertyThree>> includeThree);

        IList<T> GetListWithOneIncludes<TPropertyOne>(Expression<Func<T, TPropertyOne>> includeOne, Expression<Func<T, bool>> filter = null);
        IList<T> GetListWithTwoIncludes<TPropertyOne, TPropertyTwo>(Expression<Func<T, TPropertyOne>> includeOne, Expression<Func<T, TPropertyTwo>> includeTwo, Expression<Func<T, bool>> filter = null);
        IList<T> GetListWithThreeIncludes<TPropertyOne, TPropertyTwo, TPropertyThree>(Expression<Func<T, TPropertyOne>> includeOne, Expression<Func<T, TPropertyTwo>> includeTwo, Expression<Func<T, TPropertyThree>> includeThree, Expression<Func<T, bool>> filter = null);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        bool Contains(T entity);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
