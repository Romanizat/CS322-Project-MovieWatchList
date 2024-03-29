﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Entity
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Imdb { get; set; }
        public string Image { get; set; }

        [InverseProperty("Movie")]
        public virtual ICollection<UserMovie> UserMovies { get; set; }

        public Movie()
        {
            UserMovies = new HashSet<UserMovie>();
        }

        public string GetRating()
        {
            if (UserMovies == null || !UserMovies.Any(um => um.Rating.HasValue))
            {
                return "N/A";
            }
            else
            {
                var averageRating = UserMovies
                                        .Where(um => um.Rating.HasValue)
                                        .Average(um => um.Rating.Value);

                return $"{averageRating.ToString("0.0")}/5";
            }
        }
    }
}
