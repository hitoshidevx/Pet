﻿using System;
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

        TipoDePetRepository tipo_repo = new TipoDePetRepository();

        // GET: api/<TipoDePetController>
        [HttpGet]
        public List<TipoDePet> Get()
        {
            return tipo_repo.ListarTodos(); 
        }

        // GET api/<TipoDePetController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoDePetController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoDePetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoDePetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}