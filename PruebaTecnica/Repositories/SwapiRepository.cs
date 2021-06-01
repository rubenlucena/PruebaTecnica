using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Repositories
{
    public class SwapiRepository : ISwapiRepository
    {
        public async Task<List<UserModel>> FindByHomeWorld(string homeWorld)
        {
            if (homeWorld == "Tatooine")
            {
                return new List<UserModel>{new UserModel
                {
                    Name = "Poggle the Lesser",
                    Height = 183,
                    Specie = "Human",
                    HomeWorld = "Tatooine",
                    Gender = "Male",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow

                }};
            }

            return new List<UserModel>();
        }
    }
}
