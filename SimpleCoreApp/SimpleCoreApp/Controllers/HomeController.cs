using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public async Task<IActionResult> Index()
        {
            ViewBag.CategoryTitles = await categoriesRepository.GetAllAsync();

            return View();
        }

    }
}
