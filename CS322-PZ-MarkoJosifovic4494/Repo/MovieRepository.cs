using CS322_PZ_MarkoJosifovic4494.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Repo
{
    public class MovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public List<Movie> GetAll()
        {
            return _context.Movie.ToList();
        }

        public List<Movie> FindAllByTitle(string title)
        {
            return _context.Movie
                   .Where(m => EF.Functions.Like(m.Title, $"%{title}%"))
                   .Include(m => m.UserMovies)
                   .ToList();
        }

        public Movie GetById(int id)
        {
            return _context.Movie.Find(id);
        }

        public Movie Create(Movie movie)
        {
            _context.Movie.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public void Update(Movie movie)
        {
            _context.Movie.Update(movie);
            _context.SaveChanges();
        }

        public List<Movie> GetAllMoviesByUserIdAndStatus(int id, MovieStatus status)
        {
            return _context.UserMovie
                .Where(um => um.UserId == id && um.Status == status)
                .Select(um => um.Movie)
                .ToList();
        }
    }
}
