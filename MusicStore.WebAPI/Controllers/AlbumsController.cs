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
    public class AlbumsController : ControllerBase
    {
        private readonly IMusicStoreRepository repo;

        public AlbumsController(IMusicStoreRepository repo)
        {
            this.repo = repo;
        }
        // GET: api/<AlbumsController>
        [HttpGet]
        public IEnumerable<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("toprated/{count}")]
        public IEnumerable<Album> GetTopRated(int count)
        {
            throw new NotImplementedException();
        }

        // GET api/<AlbumsController>/5
        [HttpGet("{id}")]
        public Album GetById(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("WithGenreAndArtist")]
        List<Album> GetAlbumsWithGenreAndArtist()
        {
            throw new NotImplementedException();
        }
        // POST api/<AlbumsController>
        [HttpPost]
        public void Post([FromBody] Album album)
        {
            throw new NotImplementedException();
        }

        // PUT api/<AlbumsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Album album)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<AlbumsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
