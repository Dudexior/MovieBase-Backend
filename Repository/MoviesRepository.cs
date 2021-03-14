using DAL;
using DAL.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MovieBaseContext _dbContext;
        public MoviesRepository(MovieBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Movie> GetAllMovies()
        {
            return _dbContext.Movies;
        }

        public IQueryable<Movie> GetSingleMovie(long id)
        {
            return _dbContext.Movies.Where(movie => movie.Id == id);
        }

        public void PatchMovie(Movie patchedMovie)
        {
            _dbContext.Movies.Update(patchedMovie);
            _dbContext.SaveChangesAsync();
        }

        public Movie InsertMovie(Movie movieToAdd)
        {
            var addedMovie = _dbContext.Movies.Add(movieToAdd);
            _dbContext.SaveChanges();

            return movieToAdd;
        }
    }
}
