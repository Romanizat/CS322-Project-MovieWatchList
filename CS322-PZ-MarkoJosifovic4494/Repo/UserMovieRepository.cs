using CS322_PZ_MarkoJosifovic4494.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Repo
{
    public class UserMovieRepository
    {
        private readonly MovieDbContext _context;

        public UserMovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public UserMovie CreateUserMovie(UserMovie userMovie)
        {
            _context.UserMovie.Add(userMovie);
            _context.SaveChanges();
            return userMovie;
        }

        public UserMovie UpdateUserMovie(UserMovie userMovie)
        {
            var existingUserMovie = _context.UserMovie.Find(userMovie.Id);

            if (existingUserMovie != null)
            {
                existingUserMovie.MovieId = userMovie.MovieId;
                existingUserMovie.UserId = userMovie.UserId;
                existingUserMovie.Date = userMovie.Date;
                existingUserMovie.Rating = userMovie.Rating;
                existingUserMovie.Status = userMovie.Status;

                _context.UserMovie.Update(existingUserMovie);
                _context.SaveChanges();
                return existingUserMovie;
            }
            else
            {
                return userMovie;
            }
        }

        public bool DeleteUserMovie(int id)
        {
            var userMovie = _context.UserMovie.Find(id);
            if (userMovie != null)
            {
                _context.UserMovie.Remove(userMovie);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }

}
