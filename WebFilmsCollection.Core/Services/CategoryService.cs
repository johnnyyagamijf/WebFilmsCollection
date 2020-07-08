using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Contracts.Services;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<CategoryEntity> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public CategoryEntity GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }
    }
}
