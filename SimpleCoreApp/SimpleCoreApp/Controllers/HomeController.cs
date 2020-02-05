using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCoreApp.Models;
using SimpleCoreApp.Services.Interfaces;

namespace SimpleCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoriesRepository categoriesRepository;

        public HomeController(ILogger<HomeController> logger, ICategoriesRepository categoryRepo)
        {
            _logger = logger;
            categoriesRepository = categoryRepo;
        }

        public async Task<IActionResult> IndexAsync()
        {
           // var titles = await categoriesRepository.GetCategoryTitles();
            return View();
        }

    }
}
