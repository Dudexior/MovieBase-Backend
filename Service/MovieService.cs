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
        private readonly IMapper _mapper;
        public MovieService(IMoviesRepository moviesRepository)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<Movie, MovieDTO>()
              .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image.Image))
            );

            _moviesRepository = moviesRepository;
            _mapper = new Mapper(config);
        }


        public IQueryable<MovieDTO> GetAllMovies()
        {
            return _moviesRepository.GetAllMovies().ProjectTo<MovieDTO>(_mapper.ConfigurationProvider);
        }
        public IQueryable<MovieDTO> GetSingleMovie(long id)
        {
            return _moviesRepository.GetSingleMovie(id).ProjectTo<MovieDTO>(_mapper.ConfigurationProvider);
        }
    }
}
