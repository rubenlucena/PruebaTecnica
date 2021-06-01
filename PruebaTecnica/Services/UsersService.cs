using PruebaTecnica.Models;
using PruebaTecnica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _userRepository;
        private readonly ISwapiRepository _swapiRepository;
        public UsersService(IUsersRepository usersRepository, ISwapiRepository swapiRepository)
        {
            _userRepository = usersRepository;
            _swapiRepository = swapiRepository;
        }
        public async Task Create(UserModel model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                throw new Exception("Model is invalid");
            }

            // should use an entity but time is time :) 
            await _userRepository.Insert(model);
        }

        public async Task Delete(int id)
        {
            var user = await _userRepository.FindById(id);

            if (user == null || user.Id < 0)
            {
                throw new Exception("User not found");
            }

            await _userRepository.Delete(user);
        }

        public async Task<List<ConnectionModel>> FindByHomeworld(string homeWorld)
        {
            if (string.IsNullOrEmpty(homeWorld))
            {
                throw new Exception("HomeWorld is empty");
            }

            var usersOnOurNet = await _userRepository.FindByHomeWorld(homeWorld);
            var usersSwapi = await _swapiRepository.FindByHomeWorld(homeWorld);

            return usersOnOurNet.Select(u => new ConnectionModel
            { Name = u.Name, IsOnOurAwesomeNet = true })
                .ToList()
                .Union(usersSwapi.Select(s => new ConnectionModel
                { Name = s.Name, IsOnOurAwesomeNet = false }))
                        .ToList();
        }

        public async Task<UserModel> GetById(int id)
        {
            return await _userRepository.FindById(id);
        }

        public async Task Update(UserModel model, int id)
        {
            var user = await _userRepository.FindById(id);

            if (user == null || user.Id < 0)
            {
                throw new Exception("User not found");
            }

            user.Name = model.Name;
            user.Specie = model.Specie;
            user.Gender = model.Gender;
            user.Edited = DateTime.UtcNow;
            user.Height = model.Height;
            user.HomeWorld = model.HomeWorld;

            await _userRepository.Update(user);
        }
    }
}
