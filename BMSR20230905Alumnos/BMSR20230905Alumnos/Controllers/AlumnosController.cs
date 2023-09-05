using Microsoft.AspNetCore.Mvc;

using BMSR20230905Alumnos.Models;
namespace BMSR20230905Alumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        static List<Alumnos> alumno = new List<Alumnos>();

        [HttpGet]
        public IEnumerable<Alumnos> Get()
        {
            return alumno;
        }
        [HttpGet("{id}")]
        public Alumnos Get(int id)
        {
            var alumnos = alumno.FirstOrDefault(c => c.Id == id);
            return alumnos;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Alumnos alumnos)
        {
            alumno.Add(alumnos);
            return Ok();
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Alumnos alumnos)
        {
            var existingAlumno = alumno.FirstOrDefault(a => a.Id == id);
            if (existingAlumno != null)
            {

                existingAlumno.Name = alumnos.Name;
                existingAlumno.LastName = alumnos.LastName;
                existingAlumno.Age = alumnos.Age;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var existingAlumno = alumno.FirstOrDefault(a => a.Id == id);
            if (existingAlumno != null)
            {

                alumno.Remove(existingAlumno);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}

