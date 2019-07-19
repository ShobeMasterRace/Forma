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
        private Data.Model.IdModel IdM;

        public KorisnikController()
        {
            IdM = new Data.Model.IdModel();

        }

        public static List<Data.Model.KorisnikModel> korisnici = new List<Data.Model.KorisnikModel>
        {
            
        };

        public IEnumerable<Data.Model.KorisnikModel> GetAllProducts()
        {
            return korisnici;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var product = korisnici.FirstOrDefault((p) => p.I == id);

            if (product == null)
            {

                return StatusCode(404, "Upit nije pronađen!");

            }

            return Ok(product);
        }



    }
}