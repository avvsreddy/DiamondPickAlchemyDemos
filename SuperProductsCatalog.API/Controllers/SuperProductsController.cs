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
        [HttpGet]
        [Route("name/{pname}")]
        public ActionResult GetProductByName(string pname)
        {
            var products = (from p in db.Products
                            where p.Name.Contains(pname)
                            select p).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        // Lab 2: GET api/superproducts/brand/{apple} => returns all products belongs to apple

        [HttpGet("brand/{brand}")]
        public ActionResult GetProductsByBrand(string brand)
        {
            var products = (from p in db.Products
                            where p.Brand.Contains(brand)
                            select p).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        // Lab 3: GET api/superproducts/cheapest => return cheapest product
        [HttpGet("cheapest")]
        public IActionResult GetCheapestProduct()
        {
            var cheapestProduct = db.Products.OrderBy(p => p.Cost).FirstOrDefault();
            return Ok(cheapestProduct);
        }


        // Lab 4: GET api/superproducts/costliest => return costliest product
        [HttpGet("costliest")]
        public ActionResult<Product> GetCostliestProduct()
        {
            var costliestProduct = db.Products.OrderByDescending(p => p.Cost).FirstOrDefault();
            return Ok(costliestProduct);
        }

        // Lab 5: GET api/superproducts/costbetween/10000/50000 => return all products cost between provided value
        [HttpGet("costbetween/{min}/{max}")]
        public IActionResult GetProductsByCost(int min, int max)
        {
            var products = (from p in db.Products
                            where p.Cost >= min && p.Cost <= max
                            select p).ToList();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }


    }
}
