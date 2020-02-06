using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleCoreApp.Services.Interfaces;

namespace SimpleCoreApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly ICategoriesRepository categoriesRepository;

        public ProductsController(IProductsRepository productsRepository,
            ICategoriesRepository categoriesRepository)
        {
            this.productsRepository = productsRepository;
            this.categoriesRepository = categoriesRepository;
        }

        public async Task<IActionResult> List(int id)
        {
            ViewBag.ProductsOfCategory = await productsRepository
               .GetProductsByCategoryIdAsync(id);

            ViewBag.CategoryTitle = await categoriesRepository
                .GetTitleByIdAsync(id);

            return View();
        }

        

    }
}