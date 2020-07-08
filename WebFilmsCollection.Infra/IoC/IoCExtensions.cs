using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using WebFilmsCollection.Application.Contracts.Services;
using WebFilmsCollection.Application.Services;
using WebFilmsCollection.Core.Contracts.Repositories;
using WebFilmsCollection.Core.Contracts.Services;
using WebFilmsCollection.Core.Services;
using WebFilmsCollection.Infra.Data.Repositories;

namespace WebFilmsCollection.Infra.IoC
{
    public static class IoCExtensions
    {
        public static void ResolveDependences(this IServiceCollection service)
        {
            service.AddScoped<ICategoryAppService, CategoryAppService>();
            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<ICategoryService, CategoryService>();

            service.AddScoped<IFilmAppService, FilmAppService>();
            service.AddScoped<IFilmRepository, FilmRepository>();
            service.AddScoped<IFilmService, FilmService>();
        }
    }
}
