using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebFilmsCollection.Application.Services;
using WebFilmsCollection.Application.ViewModels;
using WebFilmsCollection.Site.Models;

namespace WebFilmsCollection.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<string>
            {
                "Rambo",
                "Matrix",
                "XMAN",
                "Batman",
                "SuperMan",
                "Velozes e furiosos",
                 "Logan",
                "Guardiões da Galáxia",
                "Mulher Maravilha",
                "Star Wars",
                "Liga da Justiça",
                "Blade Runner",
                "Vingadores",
                "Thor",
                "Homem de Ferro",
                "Homem aranha",
                "O preço  do amanhã"
            };

            List<FilmesViewModel> results = new List<FilmesViewModel>();

            foreach (var item in list)
            {
                
                var result = ResultService.Exec(item).Result;

                var filter = result.Where(x => x.thumbnail != null).ToList();

                    results.AddRange(filter);               
            }
 
            return View(results);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
