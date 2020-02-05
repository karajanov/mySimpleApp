using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleCoreApp.Models;
using SimpleCoreApp.Services.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SimpleCoreApp.Services
{
    public class ProductsRepository : Repository<Products>, IProductsRepository
    {
        public ProductsRepository(FinalDB_IPContext context)
            :base(context)
        {
        }

        public async Task<IEnumerable<string>> GetAllTitlesAsync()
        {
            var titles = await (from p in GetDbSet()
                               select p.Title).ToListAsync();

            return titles;
        }
    }
}
