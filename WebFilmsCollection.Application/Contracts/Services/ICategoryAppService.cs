using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Application.ViewModels;

namespace WebFilmsCollection.Application.Contracts.Services
{
    public interface ICategoryAppService
    {
        IEnumerable<CategoryViewModel> GetAll();
        CategoryViewModel GetById(int id);
        void Add(CategoryViewModel viewModel);
    }
}
