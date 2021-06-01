using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public interface IUsersRepository
    {
        Task Insert(UserModel model);
        Task<UserModel> FindById(int id);
        Task Delete(UserModel user);
        Task<List<UserModel>> FindByHomeWorld(string homeWorld);
        Task Update(UserModel user);
    }
}
