using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_0512.Models
{
    public class ReviewsContext : DbContext
    {
        public DbSet<Reviews> Reviews { get; set; }

        private const string connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=Reviews_10.mdb;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
