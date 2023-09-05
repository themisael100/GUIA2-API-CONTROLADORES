using Microsoft.AspNetCore.Mvc;
using BMSR20230905Materias.Models;

namespace BMSR20230905Materias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        static List<Materias> materias = new List<Materias>();

        [HttpPost]
        public IActionResult Post([FromBody] Materias materia)
        {
            materias.Add(materia);
            return Ok();
        }
        [HttpGet]
        public IEnumerable<Materias> Get()
        {
            return materias;
        }
        [HttpDelete("{id}")]


        public IActionResult Delete(int id)
        {
            var existingMateria = materias.FirstOrDefault(M => M.Id == id);
            if (existingMateria != null)
            {

                materias.Remove(existingMateria);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
