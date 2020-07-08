using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Infra.Data.Context;

namespace WebFilmsCollection.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public WebFilmCollectionDataModel _dbContext;

        public Repository(WebFilmCollectionDataModel dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
