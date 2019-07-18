using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        public KorisnikController()
        {

            



        }

        //[Route("{id}")]
        //[HttpGet]
        //public IActionResult GetProduct(int id)
        //{
        //    var product = korisnici.FirstOrDefault((p) => p.Id == id);

        //    if (product == null)
        //    {

        //        return StatusCode(404, "Upit nije pronađen!");

        //    }

        //    return Ok(product);
        //}



    }
}