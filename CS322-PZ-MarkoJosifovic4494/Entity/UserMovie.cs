using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Entity
{
    public class UserMovie
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? Rating { get; set; } // Rating might be null if the movie is on the watchlist
        public MovieStatus Status { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
    }

    public enum MovieStatus
    {
        Watched,
        WatchList
    }
}
