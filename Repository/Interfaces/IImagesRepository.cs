using DAL.Models;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IImagesRepository
    {
        public IQueryable<MovieImage> getImages();

        MovieImage InsertImage(MovieImage image);

        MovieImage UpdateImage(MovieImage image);
    }
}
