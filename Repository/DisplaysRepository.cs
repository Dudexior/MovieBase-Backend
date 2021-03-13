using DAL;
using DAL.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DisplaysRepository : IDisplaysRepository
    {
        private readonly MovieBaseContext _dbContext;
        public DisplaysRepository(MovieBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Display> GetDisplaysForMovie(long movieId)
        {
            return _dbContext.Displays.Where(display => display.Movie.Id == movieId);
        }
    }
}
