using PruebaTecnica.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnica.Services
{
    public interface IUsersService
    {
        Task<UserModel> GetById(int id);
        Task Create(UserModel model);
        Task Update(UserModel model, int id);
        Task Delete(int id);
        Task<List<ConnectionModel>> FindByHomeworld(string homeWorld);
    }
}
