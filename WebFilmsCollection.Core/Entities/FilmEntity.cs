using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebFilmsCollection.Core.Entities
{
    public class FilmEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

    }
}
