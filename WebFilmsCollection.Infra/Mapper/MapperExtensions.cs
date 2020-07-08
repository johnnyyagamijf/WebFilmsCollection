using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace WebFilmsCollection.Infra.Mapper
{
    public static class MapperExtensions
    {
        public static void  AddMapper (this IServiceCollection service)
        {
               var config = new AutoMapper.MapperConfiguration(cfg =>
               {
                   cfg.AddProfile(new MapperProfile());
               });
            var mapper = config.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
