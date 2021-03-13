using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IDisplaysRepository
    {
        IQueryable<Display> GetDisplaysForMovie(long movieId);
        void InsertDisplay(Display newDisplay);
    }
}
