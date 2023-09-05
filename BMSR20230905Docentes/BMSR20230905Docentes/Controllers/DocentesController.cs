using BMSR20230905Docentes.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMSR20230905Docentes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        static List<Docentes> Docente = new List<Docentes>();

        [HttpPost]
        public IActionResult Post([FromBody] Docentes docente)
        {
            Docente.Add(docente);
            return Ok();
        }
        [HttpGet("{id}")]
        public Docentes Get(int id)
        {
            var docentes = Docente.FirstOrDefault(D => D.Id == id);
            return docentes;
        }
    }
}
