using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleCoreApp.Models;
using SimpleCoreApp.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCoreApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository categoriesRepository;

        public ApiCategoriesController(ICategoriesRepository categoriesRepository)
        {
            this.categoriesRepository =categoriesRepository;
        }
        
        [HttpGet]
        [Route("All")] // api/ApiCategories/All
        public async Task<string> GetAllCategories()
        {
            var listOfCategories = await categoriesRepository.GetAllAsync();
            var x = JsonConvert.SerializeObject(listOfCategories);

            return x;
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromQuery] decimal price)
        {

        }
        
    }
}
