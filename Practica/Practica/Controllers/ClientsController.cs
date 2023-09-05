using Microsoft.AspNetCore.Mvc;
using Practica.Models;

namespace Practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        static List<Client> clients = new List<Client>();

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clients;
        }
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            return client;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            clients.Add(client);
            return Ok();
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id ,[FromBody] Client client) 
        {
            var existingClient = clients.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
       
                existingClient.Name = client.Name;
                existingClient.lastName = client.lastName;
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
            var existingClient = clients.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
              
                clients.Remove(existingClient);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
