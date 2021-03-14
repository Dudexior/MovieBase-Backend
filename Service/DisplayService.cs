using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL.Models;
using Repository.Interfaces;
using Service.DTO;
using Service.Interfaces;
using System.Linq;

namespace Service
{
    public class DisplayService : IDisplayService
    {
        private readonly IDisplaysRepository _displaysRepository;
        private readonly IMapper _mapper;
        public DisplayService(IDisplaysRepository displaysRepository)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Display, DisplayDTO>()
                    .ForMember(dest => dest.MovieId, opt => opt.MapFrom(src => src.Movie.Id));

                cfg.CreateMap<DisplayDTO, Display>();
            }
              
             
            );

            _displaysRepository = displaysRepository;
            _mapper = new Mapper(config);
        }

        public IQueryable<DisplayDTO> GetDisplaysForMovie(long movieId, int? top)
        {
            IQueryable<DisplayDTO> response = _displaysRepository.GetDisplaysForMovie(movieId).OrderByDescending(dis => dis.DisplayDate)
                .ProjectTo<DisplayDTO>(_mapper.ConfigurationProvider);

            if (top.HasValue)
            {
                response = response.Take(top.Value);
            }

            return response;
        }

        public void AddDisplay(long movieId, SourceTypeId source)
        {
            DisplayDTO displayToAdd = new DisplayDTO(movieId, source);

            _displaysRepository.InsertDisplay(_mapper.Map<Display>(displayToAdd));
                
        }
    }
}
