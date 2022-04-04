using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperProductsCatalog.API.Model.Data;
using SuperProductsCatalog.API.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperProductsCatalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperProductsController : ControllerBase
    {
        private readonly SuperProductsDbContext db;

        public SuperProductsController(SuperProductsDbContext db)
        {
            this.db = db;
        }

        // GET api/superproducts - retuns all products
        [HttpGet]
        public List<Product> GetProducts()
        {
            //SuperProductsDbContext db = new SuperProductsDbContext(sdfsdf);
            return db.Products.ToList();
        }

        // GET api/superproducts/1
        [HttpGet]
        [Route("{id}")]
        public ActionResult GetProduct(int id)
        {
            Product p = db.Products.Find(id);
            if (p == null)
                return NotFound(); // 404
            return Ok(p); // 200 + data
        }


        // Lab 1: GET api/superproducts/name/iphone x => returns all products with name iphone

        // Lab 2: GET api/superproducts/brand/apple => returns all products belongs to apple

        // Lab 3: GET api/superproducts/cheapest => return cheapest product

        // Lab 4: GET api/superproducts/costliest => return costliest product

        // Lab 5: GET api/superproducts/costbetween/10000/50000 => return all products cost between provided value



    }
}
