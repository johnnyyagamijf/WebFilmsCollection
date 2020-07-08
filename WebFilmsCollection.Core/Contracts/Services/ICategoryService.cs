using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Contracts.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryEntity> GetAll();
        CategoryEntity GetById(int id);
    }
}
