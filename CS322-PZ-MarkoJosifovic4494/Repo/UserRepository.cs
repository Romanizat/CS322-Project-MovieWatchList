using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS322_PZ_MarkoJosifovic4494.Entity;
using Microsoft.EntityFrameworkCore;

namespace CS322_PZ_MarkoJosifovic4494.Repo
{
    public class UserRepository
    {
        private readonly MovieDbContext _context;

        public UserRepository(MovieDbContext context)
        {
            _context = context;
        }

        public User GetByUsername(string username)
        {
            return _context.User.Include(u => u.UserMovies)
                .ThenInclude(um => um.Movie)
                .FirstOrDefault(u => u.Username == username);
        }

        public User Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool Delete(string username)
        {
            var user = _context.User.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return false;
            }

            _context.User.Remove(user);
            _context.SaveChanges();
            return true;
        }
    }
}
