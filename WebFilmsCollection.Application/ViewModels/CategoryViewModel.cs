using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Application.ViewModels
{
    public class CategoryViewModel
    {
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }
        public IEnumerable<FilmEntity> Filmes { get; set; }
    }
}
