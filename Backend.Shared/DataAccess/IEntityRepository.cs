using Backend.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Backend.Shared.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetList(Expression<Func<T,bool>> filter=null);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
