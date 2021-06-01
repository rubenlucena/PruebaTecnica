using PruebaTecnica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public interface ISwapiRepository
    {
        Task<List<UserModel>> FindByHomeWorld(string homeWorld);
    }
}
