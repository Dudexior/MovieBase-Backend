﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IMoviesRepository
    {
        IQueryable<Movie> GetAllMovies();
        IQueryable<Movie> GetSingleMovie(long id);
        Movie PatchMovie(Movie patchedMovie);
        Movie InsertMovie(Movie movieToAdd);
    }
}
