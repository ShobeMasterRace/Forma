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
        private Service.Services.Repository<Data.Model.KorisnikModel> Proba = new Service.Services.Repository<Data.Model.KorisnikModel>();
        

        public KorisnikController()
        {

        }



        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {

            return Ok(Proba.GetAll());

        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetID(int id)
        {
           
            return Ok(Proba.Get(id));
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
     
            Proba.Delete(id);

            return Ok();

        }

        [HttpPut]
        [Route("")]
        public IActionResult Edit([FromBody] Data.Model.KorisnikModel item)
        {

            return Ok(Proba.Edit(item));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Add([FromBody] Data.Model.KorisnikModel item)
        { 
            return Ok(Proba.Add(item));
        }
    }
}