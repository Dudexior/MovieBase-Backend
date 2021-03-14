using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Interfaces;
using System;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieBase.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: <MoviesController>
        [HttpGet]
        public IQueryable<MovieDTO> Get()
        {
            return _movieService.GetAllMovies();
        }

        // GET <MoviesController>/5
        [HttpGet("{id}")]
        public MovieDTO Get(long id)
        {
            SourceTypeId source = CheckSourceType();
           
            return _movieService.GetSingleMovie(id, source).FirstOrDefault();
        }

        // POST <MoviesController>
        [HttpPost]
        public IActionResult Post([FromBody] MovieDTO movie)
        {
            return StatusCode(501);
        }

        // PATCH <MoviesController>/5
        [HttpPatch("{id}")]
        public IActionResult Put(long id, [FromBody] MovieDTO movie)
        {
            return StatusCode(501);
        }

        // DELETE <MoviesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return StatusCode(501);
        }

        private SourceTypeId CheckSourceType()
        {
            SourceTypeId response = SourceTypeId.Api;
            string uiHeader = Request.Headers["FromUI"].ToString();

            if (!String.IsNullOrWhiteSpace(uiHeader) && uiHeader.ToLower() == bool.TrueString.ToLower())
            {
                response = SourceTypeId.UI;
            }

            return response;
        }
    }
}
