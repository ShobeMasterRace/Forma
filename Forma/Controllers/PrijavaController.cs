using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forma.Data.Model;
using Forma.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrijavaController : ControllerBase
    {

        private Repository<PrijavaModel> prijave = new Repository<PrijavaModel>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(prijave.GetAll());
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetID(int id)
        {
                     
            return Ok(prijave.Get(id));
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {  
            prijave.Delete(id);

            return Ok();

        }

        [HttpPut]
        public IActionResult Edit(PrijavaModel item)
        {
    
            return Ok(prijave.Edit(item));
        }

        [HttpPost]
        public IActionResult Add(PrijavaModel item)
        { 
            return Ok(prijave.Add(item));


        }

    }
}