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
    public class ProizvodiController : ControllerBase
    {
        private Service.Services.Repository<Data.Model.ProizvodModel> Test = new Service.Services.Repository<Data.Model.ProizvodModel>();
        public ProizvodiController()
        {

        }



        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {

            return Ok(Test.GetAll());

        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetID(int id)
        {

            return Ok(Test.Get(id));
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {

            Test.Delete(id);

            return Ok();

        }

        [HttpPut]
        [Route("")]
        public IActionResult Edit([FromBody] Data.Model.ProizvodModel item)
        {

            return Ok(Test.Edit(item));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Add([FromBody] Data.Model.ProizvodModel item)
        {
            return Ok(Test.Add(item));
        }
    }
}