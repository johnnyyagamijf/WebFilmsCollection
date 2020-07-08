using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using WebFilmsCollection.Application.ViewModels;
using WebFilmsCollection.Core.Entities;

namespace WebFilmsCollection.Infra.Mapper
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {
            this.CreateMap<FilmEntity, FilmViewModel>().ReverseMap();
            this.CreateMap<CategoryEntity, CategoryViewModel>().ReverseMap();
        }
    }
}
