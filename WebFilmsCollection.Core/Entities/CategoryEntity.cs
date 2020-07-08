using System;
using System.Collections.Generic;
using System.Text;

namespace WebFilmsCollection.Core.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<FilmEntity> Filmes { get; set; }
    }
}
