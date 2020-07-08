using System;
using System.Collections.Generic;
using System.Text;

namespace WebFilmsCollection.Core.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        void Add(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
    }
}
