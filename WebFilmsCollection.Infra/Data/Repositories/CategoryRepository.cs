using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Entities;
using WebFilmsCollection.Infra.Data.Context;

namespace WebFilmsCollection.Infra.Data.Repositories
{
    public class CategoryRepository : Repository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(WebFilmCollectionDataModel dbContext) : base(dbContext)
        {
        }

        public void Add(CategoryEntity entity)
        {
            _dbContext.Set<CategoryEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<CategoryEntity> GetAll()
        {
            return _dbContext.Set<CategoryEntity>();
        }

        public CategoryEntity GetById(int id)
        {
            return _dbContext.Set<CategoryEntity>().Find(id);
        }
    }
}
