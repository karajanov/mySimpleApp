using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleCoreApp.Models;
using SimpleCoreApp.Services.Interfaces;

namespace SimpleCoreApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductsController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;

        public ApiProductsController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        [HttpPut("{id}")]
        public async Task<HttpResponseMessage> Put(int id, [FromQuery] decimal price)
        {
            if (id != 0)
            {
                var existingProduct = await productsRepository.GetByIdAsync(id);
                existingProduct.Price = price;

                try
                {
                    await productsRepository.UpdateAsync(existingProduct);
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                }
                catch
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                }
            }

            return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
        }
    }
}