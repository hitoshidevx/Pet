using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPet.Domains;
using APIPet.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacaController : ControllerBase
    {
        RacaRepository raca = new RacaRepository();
        // GET: api/<RacaController>
        [HttpGet]
        public List<Raca> Get()
        {
            return raca.ListarTodos();
        }

        // GET api/<RacaController>/5
        [HttpGet("{id}")]
        public Raca Get(int id)
        {
            return raca.BuscarPorID(id);
        }

        // POST api/<RacaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RacaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RacaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
