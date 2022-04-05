using Microsoft.AspNetCore.Mvc;
using MusicStore.WebAPI.Models.Entities;
using System.Collections.Generic;
using System;
using MusicStore.WebAPI.Models.Data;


// TODO - Implement below all action methods


namespace MusicStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IMusicStoreRepository repo;

        public GenresController(IMusicStoreRepository repo)
        {
            this.repo = repo;
        }
        // GET: api/<GenresController>
        [HttpGet]
        public IEnumerable<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<GenresController>
        [HttpPost]
        public void Post([FromBody] Genre genre)
        {
            throw new NotImplementedException();
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genre genre)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
