using CS322_PZ_MarkoJosifovic4494.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
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

            //// Attach the user and movie to the context if they aren't already tracked
            //_context.User.Attach(userMovie.User);
            //_context.Movie.Attach(userMovie.Movie);

            //// Set their state to Unchanged to avoid EF trying to add them as new entities
            //_context.Entry(userMovie.User).State = EntityState.Unchanged;
            //_context.Entry(userMovie.Movie).State = EntityState.Unchanged;


            _context.UserMovie.Add(userMovie);
            _context.SaveChanges();
            return userMovie;
        }

        public void UpdateUserMovie()
        {
                _context.SaveChanges();
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

        public UserMovie FindByUserAndMovie(int userId, int movieId)
        {
            return _context.UserMovie
                .FirstOrDefault(um => um.User.Id == userId && um.Movie.Id == movieId);
        }
    }

}
