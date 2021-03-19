using DAL.Models;
using Service.DTO;
using System.Linq;

namespace Service.Interfaces
{
    public interface IMovieService
    {
        IQueryable<MovieDTO> GetAllMovies();
        IQueryable<MovieDTO> GetSingleMovie(long id, SourceTypeId source);
        MovieDTO EditMovie(long id, MovieSimpleDTO editedMovie);
        MovieDTO EditMovieImage(long id, byte[] imageBytes);
        MovieDTO AddMovie(MovieSimpleDTO movieToAdd);
        MovieDTO DisableMovie(long id);
    }
}
