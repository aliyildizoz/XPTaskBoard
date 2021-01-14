using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Entities;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public abstract class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public TEntity GetWithOneIncludes<TPropertyOne>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TPropertyOne>> includeOne)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Include(includeOne).SingleOrDefault(filter);
            }
        }

        public TEntity GetWithTwoIncludes<TPropertyOne, TPropertyTwo>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TPropertyOne>> includeOne, Expression<Func<TEntity, TPropertyTwo>> includeTwo)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Include(includeOne).Include(includeTwo).SingleOrDefault(filter);
            }
        }

        public TEntity GetWithThreeIncludes<TPropertyOne, TPropertyTwo, TPropertyThree>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TPropertyOne>> includeOne,
            Expression<Func<TEntity, TPropertyTwo>> includeTwo, Expression<Func<TEntity, TPropertyThree>> includeThree)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Include(includeOne).Include(includeTwo).Include(includeThree).SingleOrDefault(filter);
            }
        }

        public IList<TEntity> GetListWithOneIncludes<TPropertyOne>(Expression<Func<TEntity, TPropertyOne>> includeOne, Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Include(includeOne).Where(filter).ToList();
            }
        }

        public IList<TEntity> GetListWithTwoIncludes<TPropertyOne, TPropertyTwo>(Expression<Func<TEntity, TPropertyOne>> includeOne, Expression<Func<TEntity, TPropertyTwo>> includeTwo,
            Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Include(includeOne).Include(includeTwo).Where(filter).ToList();
            }
        }

        public IList<TEntity> GetListWithThreeIncludes<TPropertyOne, TPropertyTwo, TPropertyThree>(Expression<Func<TEntity, TPropertyOne>> includeOne, Expression<Func<TEntity, TPropertyTwo>> includeTwo,
            Expression<Func<TEntity, TPropertyThree>> includeThree, Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Include(includeOne).Include(includeTwo).Include(includeThree).Where(filter).ToList();
            }
        }


        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public bool Contains(TEntity entity)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Contains(entity);
            }
        }

        public virtual void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public virtual void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
