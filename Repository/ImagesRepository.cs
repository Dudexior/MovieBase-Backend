using DAL;
using DAL.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ImagesRepository : IImagesRepository
    {
        private readonly MovieBaseContext _dbContext;
        public ImagesRepository(MovieBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MovieImage> getImages()
        {
            return _dbContext.MovieImages;
        }

        public MovieImage InsertImage(MovieImage image)
        {
            _dbContext.Add(image);
            _dbContext.SaveChanges();

            return image;
        }

        public MovieImage UpdateImage(MovieImage image) 
        {
            _dbContext.Update(image);
            _dbContext.SaveChanges();

            return image;
        }
    }
}
