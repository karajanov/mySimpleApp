using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleCoreApp.Services.Interfaces
{
    public interface ITitles
    {
        Task<IEnumerable<string>> GetAllTitlesAsync();
        Task<string> GetTitleByIdAsync(int id);
    }
}
