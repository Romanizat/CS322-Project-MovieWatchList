using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS322_PZ_MarkoJosifovic4494.Entity;
using Microsoft.EntityFrameworkCore;

namespace CS322_PZ_MarkoJosifovic4494.Repo
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.UserMovies)
                .WithOne(e => e.User);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.UserMovies)
                .WithOne(e => e.Movie);

            modelBuilder.Entity<UserMovie>(entity =>
            {
                entity.Property(e => e.MovieId).HasColumnName("movie_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.HasOne(e => e.User).WithMany(e => e.UserMovies).HasForeignKey(e=>e.UserId);
                entity.HasOne(e => e.Movie).WithMany(e => e.UserMovies).HasForeignKey(e => e.MovieId);
                entity.Property(um => um.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (MovieStatus)Enum.Parse(typeof(MovieStatus), v)
                )
                ;
            });

            // Other configurations...
        }

    }
}
