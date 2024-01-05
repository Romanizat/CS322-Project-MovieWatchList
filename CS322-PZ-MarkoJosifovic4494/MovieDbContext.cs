using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace CS322_PZ_MarkoJosifovic4494
{
    public class MovieDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserMovie> UserMovie { get; set; }
        public DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=movie_watchlist;Uid=root;Pwd=;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
