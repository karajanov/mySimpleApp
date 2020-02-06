using Microsoft.AspNetCore.Mvc;
using SimpleCoreApp.Services.Interfaces;

namespace SimpleCoreApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCategoriesController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;

        public ApiCategoriesController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        
        
    }
}
