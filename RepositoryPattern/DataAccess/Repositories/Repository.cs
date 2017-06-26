using RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RepositoryPattern.DataAccess.Repositories
{
    /// <summary>
    /// Implementation of IRepository Interface.
    /// This is a generic repository class that has common methods 
    /// such as add, addRange, find, and so on
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
  class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SampleContext _context;
        public Repository(SampleContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
             _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
             _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
