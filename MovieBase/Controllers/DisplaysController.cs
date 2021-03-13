using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieBase.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DisplaysController : ControllerBase
    {
        private readonly IDisplayService _displayService;
        public DisplaysController(IDisplayService displayService)
        {
            _displayService = displayService;
        }


        // GET <DisplaysController>/5
        [HttpGet("{movieId}")]
        public IQueryable<DisplayDTO> Get(long movieId, int? top)
        {
            return _displayService.GetDisplaysForMovie(movieId, top);
        }
    }
}
