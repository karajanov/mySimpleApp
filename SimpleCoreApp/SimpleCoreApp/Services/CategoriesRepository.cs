using Microsoft.EntityFrameworkCore;
using SimpleCoreApp.Models;
using SimpleCoreApp.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCoreApp.Services
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(FinalDB_IPContext context)
            :base(context)
        {
        }

        public async Task<IEnumerable<string>> GetAllTitlesAsync()
        {
            var titles = await (from c in GetDbSet()
                                select c.Title).ToListAsync();

            return titles;
        }
    }
}
