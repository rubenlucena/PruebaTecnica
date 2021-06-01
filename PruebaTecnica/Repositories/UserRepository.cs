using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public class UserRepository : IUsersRepository
    {
        private readonly AwesomeNetDBContext _context;

        public UserRepository(AwesomeNetDBContext context)
        {
            _context = context;
        }

        public async Task Delete(UserModel user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserModel>> FindByHomeWorld(string homeWorld)
        {
            return await _context.Users.Where(u => u.HomeWorld == homeWorld).ToListAsync();
        }

        public async Task<UserModel> FindById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task Insert(UserModel model)
        {
            await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Update(UserModel user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
