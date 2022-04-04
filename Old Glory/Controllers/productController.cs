using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Old_Glory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProducts()
        {
            string[] product = { "product" };

            if (product.Any())
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult CreateNewProduct()
        {

        }

        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }


    }
}
