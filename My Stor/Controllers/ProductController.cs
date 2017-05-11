
using My_Stor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using My_Stor;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
      Stor_Db ctx = new Stor_Db();

      


      
        public IEnumerable<Product> GetAllProducts()
        {
         var   products = ctx.Products.ToList();
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = ctx.Products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}