using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Entities;
using WebFilmsCollection.Infra.Data.Context;

namespace WebFilmsCollection.Infra.Data.Repositories
{
    public class FilmRepository : Repository<FilmEntity>, IFilmRepository
    {
        public FilmRepository(WebFilmCollectionDataModel dbContext) : base(dbContext)
        {
        }

        public void Add(FilmEntity entity)
        {
            _dbContext.Set<FilmEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<FilmEntity> GetAll()
        {
            return _dbContext.Set<FilmEntity>();
        }

        public FilmEntity GetById(int id)
        {
            return _dbContext.Set<FilmEntity>().FirstOrDefault(f => f.Id == id);
        }

        
    }
}
