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
        private readonly DbSet<Categories> categories;

        public ProductsRepository(FinalDB_IPContext context)
            :base(context)
        {
            categories = context.Set<Categories>();
        }

        public async Task<IEnumerable<string>> GetAllTitlesAsync()
        {
            var titles = await (from p in GetDbSet()
                               select p.Title).ToListAsync();

            return titles;
        }

        public async Task<IEnumerable<Products>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await (from p in GetDbSet()
                                  join c in categories on p.CategoryId equals c.Id
                                  where c.Id == categoryId
                                  select p).ToListAsync();

            return products;
        }

        public async Task<string> GetTitleByIdAsync(int id)
        {
            return await (from p in GetDbSet()
                          where p.Id == id
                          select p.Title).FirstOrDefaultAsync();
        }
    }
}
