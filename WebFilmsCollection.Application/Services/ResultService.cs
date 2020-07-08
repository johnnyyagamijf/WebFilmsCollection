using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebFilmsCollection.Application.ViewModels;

namespace WebFilmsCollection.Application.Services
{
    public static class ResultService
    {
        private const string _URLAPIPRODUCT = "http://essearch.allocine.net/br/autocomplete?q=";
        public async static Task<List<FilmesViewModel>> GetFilmestAsync(string name)
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(_URLAPIPRODUCT +name);
            return JsonConvert.DeserializeObject<List<FilmesViewModel>>(result);
        }

        public async static Task<List<FilmesViewModel>> Exec(string name)
        {
            return await GetFilmestAsync(name);
        }
    }
}
