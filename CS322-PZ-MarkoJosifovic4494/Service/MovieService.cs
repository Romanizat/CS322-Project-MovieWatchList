using CS322_PZ_MarkoJosifovic4494.Repo;
using CS322_PZ_MarkoJosifovic4494.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_PZ_MarkoJosifovic4494.Service
{
    public class MovieService
    {
        private readonly MovieRepository _movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Movie CreateMovie(string title, string summary, string imdb, string imageUrl)
        {
            var newMovie = new Movie
            {
                Title = title,
                Summary = summary,
                Imdb = imdb,
                Image= imageUrl
            };

            return _movieRepository.Create(newMovie);
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAll();
        }

        public List<Movie> FindAllByTitle(string title)
        {
            return _movieRepository.FindAllByTitle(title);
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public void UpdateMovie(int id, string title, string summary, string imdb, string imageUrl)
        {
            Movie movie = GetById(id);
            movie.Title = title;
            movie.Summary = summary;
            movie.Imdb = imdb;
            movie.Image = imageUrl;
            _movieRepository.Update(movie);
        }
    }
}
