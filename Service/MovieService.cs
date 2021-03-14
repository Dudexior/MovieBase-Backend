using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL.Models;
using Repository.Interfaces;
using Service.DTO;
using Service.Interfaces;
using System.Linq;

namespace Service
{
    public class MovieService : IMovieService
    {
        private readonly IMoviesRepository _moviesRepository;
        private readonly IDisplayService _displayService;
        private readonly IMapper _mapper;
        public MovieService(IMoviesRepository moviesRepository, IDisplayService displayService)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<Movie, MovieDTO>()
              .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image.Image))
            );

            _moviesRepository = moviesRepository;
            _displayService = displayService;
            _mapper = new Mapper(config);
        }


        public IQueryable<MovieDTO> GetAllMovies()
        {
            return _moviesRepository.GetAllMovies().ProjectTo<MovieDTO>(_mapper.ConfigurationProvider);
        }

        public IQueryable<MovieDTO> GetSingleMovie(long id, SourceTypeId source)
        {
            _displayService.AddDisplay(id, source);
            return _moviesRepository.GetSingleMovie(id).ProjectTo<MovieDTO>(_mapper.ConfigurationProvider);
        }

        public MovieDTO EditMovie(long id, MovieSimpleDTO editedMovie)
        {
            Movie movieToEdit = _moviesRepository.GetSingleMovie(id).FirstOrDefault();

            if (movieToEdit == null)
            {
                throw new System.Exception("Object not found");
            }

            movieToEdit.Description = editedMovie.Description;
            movieToEdit.Duration = editedMovie.Duration;
            movieToEdit.Title = editedMovie.Title;

            return _mapper.Map<MovieDTO>(_moviesRepository.PatchMovie(movieToEdit));
        }

        public MovieDTO AddMovie(MovieSimpleDTO movie)
        {
            Movie movieToAdd = new Movie()
            {
                Title = movie.Title,
                Description = movie.Description,
                Duration = movie.Duration
            };

            return _mapper.Map<MovieDTO>(_moviesRepository.InsertMovie(movieToAdd));
        }
    }
}
