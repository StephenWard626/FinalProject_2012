using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_0512.Models
{
    public class GroupContext : DbContext
    {
        public DbSet<Groups> Groups { get; set; }

        private const string connectionString =
            "Server=tcp:swsubmission.database.windows.net,1433;Initial Catalog=Groups;Persist Security Info=False;User ID=sward;Password=Kingdom2Hearts;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
