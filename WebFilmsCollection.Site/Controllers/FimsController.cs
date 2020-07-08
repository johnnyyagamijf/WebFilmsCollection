using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebFilmsCollection.Application.Contracts.Services;
using WebFilmsCollection.Application.ViewModels;

namespace WebFilmsCollection.Site.Controllers
{
    public class FimsController : Controller
    {
        private readonly IFilmAppService _filmAppService;
        private readonly ICategoryAppService _categoryAppService;

        public FimsController(IFilmAppService filmAppService, ICategoryAppService categoryAppService)
        {
            _filmAppService = filmAppService;
            _categoryAppService = categoryAppService;
        }

        public IActionResult Index()
        {
            var films = _filmAppService.GetAll();
            return View(films);
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_categoryAppService.GetAll(), "Id", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult Create(FilmViewModel view)
        {
            _filmAppService.Add(view);
            return RedirectToAction("Index","Fims");
        }
    }
}