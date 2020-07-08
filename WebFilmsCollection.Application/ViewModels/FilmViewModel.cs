using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Application.ViewModels
{
    public class FilmViewModel
    {
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [DisplayName("Descriçãos")]
        public CategoryEntity Category { get; set; }
    }
}
