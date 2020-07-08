using System;
using System.Collections.Generic;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Core.Contracts.Repositories
{
    public interface IFilmRepository : IRepository<FilmEntity>
    {
        IEnumerable<FilmEntity> GetAll();
       FilmEntity GetById(int id);
    }
}
