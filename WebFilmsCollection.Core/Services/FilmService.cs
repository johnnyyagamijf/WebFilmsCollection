using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Contracts.Services;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filme)
        {
            _filmRepository = filme;
        }
        public IEnumerable<FilmEntity> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public FilmEntity GetById(int id)
        {
            return _filmRepository.GetById(id);
        }
    }
}
