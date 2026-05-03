using Microsoft.AspNetCore.Mvc;

namespace TP_MODUL10_103022400034.Controllers
{
    [Route("api/Film")]
    [ApiController]
    public class FilmController:ControllerBase
    {
        private static List<Film> dataFilm = new List<Film>
        {
            new Film { Judul = "Inception", Sutradara = "Christopher Nolan", Tahun = "2010", Genre = "Sci-Fi", Rating = "9.0" },
            new Film { Judul = "Interstellar", Sutradara = "Christopher Nolan", Tahun = "2014", Genre = "Sci-Fi", Rating = "8.7" },
            new Film { Judul = "Parasite", Sutradara = "Bong Joon-ho", Tahun = "2019", Genre = "Thriller", Rating = "8.6" }
        };
        
        //GET /api/Film
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return dataFilm;
        }
        
        //GET api/Film/{id}
        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id)
        {
            if (id < 0 || id >= dataFilm.Count) return NotFound();
            return dataFilm[id];
        }
        
        //POST /api/Film
        [HttpPost]
        public void Post([FromBody] Film newFilm)
        {
            dataFilm.Add(newFilm);
        }
        
        //DELETE /api/Film/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= dataFilm.Count) return NotFound();
            dataFilm.RemoveAt(id);
            return Ok();
        }
    }
}
