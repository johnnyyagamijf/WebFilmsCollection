using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Contracts.Services
{
    public interface IFilmService
    {
        IEnumerable<FilmEntity> GetAll();
      FilmEntity GetById(int id);
    }
}
