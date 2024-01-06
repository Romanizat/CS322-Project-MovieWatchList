using CS322_PZ_MarkoJosifovic4494.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS322_PZ_MarkoJosifovic4494.Entity;

namespace CS322_PZ_MarkoJosifovic4494.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User RegisterUser(string username, string password, string name, string surname, string email, DateTime dateOfBirth)
        {
            var hashedPassword = HashPassword(password);

            var newUser = new User
            {
                Username = username,
                Password = hashedPassword,
                Name = name,
                Surname = surname,
                Email = email,
                DateOfBirth = dateOfBirth
            };

            return _userRepository.Create(newUser);
        }

        public bool LoginUser(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);

            if (user != null)
            {
                return VerifyPassword(password, user.Password); // Assuming user.Password is hashed
            }

            return false;
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        }
    }

}
