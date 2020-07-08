using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Infra.Data.Context
{
    public class WebFilmSeedEntity
    {
        public static void Seed(WebFilmCollectionDataModel contex)
        {
            contex.Database.EnsureCreated();

            if (!contex.Films.Any())
            {
                //var categories = new List<CategoryEntity>
                //{
                //    new CategoryEntity{ Description = "Ação"},
                //    new CategoryEntity{ Description = "Romance"},
                //    new CategoryEntity{ Description = "Terror"},
                //    new CategoryEntity{ Description = "Comédia"},
                //};

                //contex.AddRange(categories);
                //contex.SaveChanges();

                //var films = new List<FilmEntity>
                //{
                //    new FilmEntity{CategoryId = 1, Name = "Rambo"},
                //    new FilmEntity{CategoryId = 2, Name = "Como se fosse a primeira vez"},
                //    new FilmEntity{CategoryId = 3, Name = "IT"},
                //    new FilmEntity{CategoryId = 4, Name = "As branquelas"}

                //};

                //contex.AddRange(films);
                //contex.SaveChanges();
            }
        }
    }
}
