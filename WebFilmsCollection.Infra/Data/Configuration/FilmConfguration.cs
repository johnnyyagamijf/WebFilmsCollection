using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebFilmsCollection.Core.Entities;
using WebFilmsCollection.Infra.Data.Context;

namespace WebFilmsCollection.Infra.Data.Configuration
{
    public class FilmConfguration : IEntityTypeConfiguration<FilmEntity>
    {
        public void Configure(EntityTypeBuilder<FilmEntity> builder)
        {
            builder.ToTable("Film");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(100)");
        }
    }
}
