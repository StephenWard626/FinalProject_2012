using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_0512.Models;

namespace FinalProject_0512.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<AdminUsers> Users { get; set; }

        private const string connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=Users_10.mdb;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }

        public DbSet<FinalProject_0512.Models.Users> Users_1 { get; set; }
    }
}
