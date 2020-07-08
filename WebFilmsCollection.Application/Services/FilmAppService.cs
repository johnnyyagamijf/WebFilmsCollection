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
    public class FilmAppService : IFilmAppService
    {
        private readonly IFilmRepository _filmeFilmRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public FilmAppService(IFilmRepository filmeFilmRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _filmeFilmRepository = filmeFilmRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public IEnumerable<FilmViewModel> GetAll()
        {
            var films = _filmeFilmRepository.GetAll();
            var list = new List<FilmEntity>();
            var categories = _categoryRepository.GetAll();

            foreach (var item in films)
            {
                var category =_categoryRepository.GetById(item.CategoryId);
                item.Category.Description = category.Description;
                list.Add(item);

            }

            return _mapper.Map<IEnumerable<FilmEntity>, IEnumerable<FilmViewModel>>(list);
        }

        public FilmViewModel GetById(int id)
        {
            var films = _filmeFilmRepository.GetById(id);
            return _mapper.Map<FilmEntity, FilmViewModel>(films);
        }

        public void Add(FilmViewModel viewModel)
        {
            var film = _mapper.Map<FilmViewModel, FilmEntity>(viewModel);
            _filmeFilmRepository.Add(film);
        }
    }
}
