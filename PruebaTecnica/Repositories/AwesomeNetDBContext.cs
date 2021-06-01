using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System;

namespace PruebaTecnica.Repositories
{
    public class AwesomeNetDBContext : DbContext
    {
        public AwesomeNetDBContext(DbContextOptions options) : base(options)
        {

        }

        protected AwesomeNetDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    Height = 172,
                    Specie = "Human",
                    HomeWorld = "Tatooine",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow

                },
                new UserModel
                {
                    Id = 2,
                    Name = "C-3PO",
                    Height = 167,
                    Specie = "Droid",
                    HomeWorld = "Tatooine",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow,
                },
                new UserModel
                {
                    Id = 3,
                    Name = "Leia Organa",
                    Height = 150,
                    Specie = "Human",
                    HomeWorld = "Alderaan",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow,
                }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}AwesomeNet.db");

        public DbSet<UserModel> Users { get; set; }
    }
}
