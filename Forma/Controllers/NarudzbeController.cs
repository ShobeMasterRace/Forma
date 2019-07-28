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
    public class NarudzbeController : ControllerBase
    {
        protected readonly ReposetoryNarudzba _reposetory;
        public NarudzbeController(ReposetoryNarudzba repository)
        {
            _reposetory = repository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            return Ok(_reposetory.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_reposetory.Get(id));
        }

        [HttpPost, Route("")]
        public IActionResult Create([FromBody] Narudzbe model)
        {
            return Ok(_reposetory.Add(model));
        }

        [HttpPut, Route("")]
        public IActionResult Edit([FromBody] Narudzbe model)
        {
            return Ok(_reposetory.Edit(model));
        }

        [HttpDelete, Route("{id}")]
        public IActionResult Delete(int id)
        {
            _reposetory.Delete(id);
            return Ok();
        }

    }
}