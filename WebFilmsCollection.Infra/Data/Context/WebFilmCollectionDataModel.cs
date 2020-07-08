using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebFilmsCollection.Core.Entities;
using WebFilmsCollection.Infra.Data.Configuration;

namespace WebFilmsCollection.Infra.Data.Context
{
    public class WebFilmCollectionDataModel : DbContext
    {
        public WebFilmCollectionDataModel(DbContextOptions<WebFilmCollectionDataModel>options)
        :base(options)
        {      
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FilmConfguration());
            builder.ApplyConfiguration(new CategoryConfguration());

            builder.Entity<FilmEntity>()
                .Property<int>("CategoryId");

            builder.Entity<FilmEntity>()
                .HasOne(p => p.Category)
                .WithMany(b => b.Filmes)
                .HasForeignKey("CategoryId");
        }

        public DbSet<FilmEntity> Films { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

    }
}
