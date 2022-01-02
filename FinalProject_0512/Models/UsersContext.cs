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
             "Server=tcp:swsubmission.database.windows.net,1433;Initial Catalog=Users;Persist Security Info=False;User ID=sward;Password=Kingdom2Hearts;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }

        //public DbSet<FinalProject_0512.Models.Users> Users_1 { get; set; }

        //public DbSet<FinalProject_0512.Models.Users> Users_1 { get; set; }

        
    }
}
