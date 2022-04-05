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
    public class ArtistsController : ControllerBase
    {
        private readonly IMusicStoreRepository repo;

        public ArtistsController(IMusicStoreRepository repo)
        {
            this.repo = repo;
        }
        // GET: api/<ArtistsController>
        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<ArtistsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<ArtistsController>
        [HttpPost]
        public void Post([FromBody] Artist artist)
        {
            throw new NotImplementedException();
        }

        // PUT api/<ArtistsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Artist artist)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<ArtistsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
