using Service.DTO;
using System.Linq;

namespace Service.Interfaces
{
    public interface IDisplayService
    {
        IQueryable<DisplayDTO> GetDisplaysForMovie(long movieId, int? top);
    }
}
