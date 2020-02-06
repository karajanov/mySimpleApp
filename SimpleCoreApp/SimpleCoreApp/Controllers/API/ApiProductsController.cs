using System.Net.Http;
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
        public HttpResponseMessage Put(int id, [FromQuery] decimal price)
        {
            if (id != 0)
            {
                var product = new Products()
                {
                    Id = id,
                    Price = price
                };

                try
                {
                    productsRepository.UpdateAsync(product);
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