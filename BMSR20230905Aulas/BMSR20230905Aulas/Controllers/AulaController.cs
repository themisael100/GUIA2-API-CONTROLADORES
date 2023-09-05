using Microsoft.AspNetCore.Mvc;
using BMSR20230905Aulas.Models;

namespace BMSR20230905Aulas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        private readonly List<Aulas> aulas;

        public AulaController()
        {
            aulas = new List<Aulas>
            {
                new Aulas { Id = 1, classroom = "Aula Sociles" },
                new Aulas { Id = 2, classroom = "Aula Matematicas" },
                new Aulas { Id = 3, classroom = "Aula Lenguaje" }
               
            };
        }

        [HttpGet]
        public IActionResult ObtenerTodasLasAulas()
        {
            return Ok(aulas);
        }
    }

}

