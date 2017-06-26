using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Repositories
{
    /// <summary>
    /// This is a generic implementation of the repository- Can be used in any application
    /// Created By : Sudeep Devkota
    /// Created on : March 28, 2017
    /// Last Modified Date: April 15, 2017 by Sudeep Devkota
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    interface IRepository<TEntity> where TEntity:class
    {
        //Look up groups
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Add Groups
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //Remove groups
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
