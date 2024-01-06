using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Store hashed passwords only for security reasons
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<UserMovie> UserMovies { get; set; }

        public User()
        {
            UserMovies = new HashSet<UserMovie>();
        }
    }
}
