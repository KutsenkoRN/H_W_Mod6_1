using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.Xml;

namespace Catalog.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CatalogController : ControllerBase
    {
        private List<Product> products = new List<Product>()
        {

            new Product(1, "Apple", 35),
            new Product(2, "Pear", 40),
            new Product(3, "Orange", 130),
            new Product(4, "Plum", 45),
            new Product(5, "Strawberry", 140),
            new Product(6, "Banana", 55),
            new Product(7, "Kiwi", 80),


        };

            [HttpGet]
        public List<Product> GetAllProducts()
       {
          List<Product> sorted = products.OrderBy(x => x.Price).ToList();
          return sorted;
       }


    }
      
    
}