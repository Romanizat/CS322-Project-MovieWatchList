using CS322_PZ_MarkoJosifovic4494.Repo;
using CS322_PZ_MarkoJosifovic4494.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS322_PZ_MarkoJosifovic4494.Service
{
    public class MovieService
    {
        private readonly MovieRepository _movieRepository;
        private readonly UserMovieRepository _userMovieRepository;

        public MovieService(MovieRepository movieRepository, UserMovieRepository userMovieRepository)
        {
            _movieRepository = movieRepository;
            _userMovieRepository = userMovieRepository;
        }


        public Movie CreateMovie(string title, string summary, string imdb, string imageUrl)
        {
            var newMovie = new Movie
            {
                Title = title,
                Summary = summary,
                Imdb = imdb,
                Image = imageUrl
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

        public void AddOrUpdateUserMovie(Movie movie, User user, MovieStatus status)
        {

            var userMovie = _userMovieRepository.FindByUserAndMovie(user.Id, movie.Id);

            if (userMovie != null)
            {
                userMovie.Status = status;
                userMovie.Date = DateTime.Now;
                _userMovieRepository.UpdateUserMovie();
            }
            else
            {
                userMovie = new UserMovie
                {
                    MovieId = movie.Id,
                    UserId = user.Id,
                    Status = status,
                    Date = DateTime.Now
                };

                _userMovieRepository.CreateUserMovie(userMovie);
            }
        }

        public UserMovie GetUserMovieByUserAndMovie(User user, Movie movie)
        {
            return _userMovieRepository.FindByUserAndMovie(user.Id, movie.Id);
        }

        public void deleteUserMovie(UserMovie userMovie)
        {
            if (userMovie != null)
            {
                _userMovieRepository.DeleteUserMovie(userMovie.Id);
            }
        }
    }
}
