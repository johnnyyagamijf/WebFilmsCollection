using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Application.ViewModels;

namespace WebFilmsCollection.Application.Contracts.Services
{
    public interface IFilmAppService
    {
        IEnumerable<FilmViewModel> GetAll();
        FilmViewModel GetById(int id);
        void Add(FilmViewModel viewModel);
    }
}
