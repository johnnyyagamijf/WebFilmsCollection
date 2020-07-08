using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Contracts.Repositories
{
    public interface ICategoryRepository : IRepository<CategoryEntity>
    {
        IEnumerable<CategoryEntity> GetAll();
        CategoryEntity GetById(int id);
    }
}
