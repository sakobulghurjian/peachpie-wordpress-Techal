using app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<int> Products()
        {
            List<int> a = new List<int>();
            a.Add(2); a.Add(0); a.Add(7); a.Add(35); a.Add(12);
            return a;
        }

        public void PostProduct(Product product)
        {
            //if (ModelState.IsValid && product != null)
            //{
            //    // Create a 201 response.
            //}
            //else
            //{
            //}
        }

    }
}
