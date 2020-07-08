using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using WebFilmsCollection.Application.Contracts.Services;
using WebFilmsCollection.Application.ViewModels;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Application.Services
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryAppService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public IEnumerable<CategoryViewModel> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryEntity>, IEnumerable<CategoryViewModel>>(categories);
        }

        public CategoryViewModel GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            return _mapper.Map<CategoryEntity, CategoryViewModel>(category);
        }

        public void Add(CategoryViewModel viewModel)
        {
            var category = _mapper.Map<CategoryViewModel, CategoryEntity>(viewModel);
            _categoryRepository.Add(category);
        }
    }
}
