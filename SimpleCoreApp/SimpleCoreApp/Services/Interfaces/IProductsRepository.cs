using SimpleCoreApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCoreApp.Services.Interfaces
{
    public interface IProductsRepository : IRepository<Products>, ITitles
    {
        Task<IEnumerable<Products>> GetProductsByCategoryIdAsync(int categoryId);
    }
}
