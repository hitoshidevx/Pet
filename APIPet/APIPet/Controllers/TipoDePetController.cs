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
    public class TipoDePetController : ControllerBase
    {

        TipoDePetRepository tipo = new TipoDePetRepository();

        // GET: api/<TipoDePetController>
        [HttpGet]
        public List<TipoDePet> Get()
        {
            return tipo.ListarTodos(); 
        }

        // GET api/<TipoDePetController>/5
        [HttpGet("{id}")]
        public TipoDePet Get(int id)
        {
            return tipo.BuscarPorID(id);
        }

        // POST api/<TipoDePetController>
        [HttpPost]
        public TipoDePet Post([FromBody] TipoDePet pet)
        {
            return tipo.Cadastrar(pet);
        }

        // PUT api/<TipoDePetController>/5
        [HttpPut("{id}")]
        public TipoDePet Put(int id, [FromBody] TipoDePet pet)
        {
            return tipo.Alterar(id, pet);
        }

        // DELETE api/<TipoDePetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tipo.Excluir(id);
        }
    }
}
