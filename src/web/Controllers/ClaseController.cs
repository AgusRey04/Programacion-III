using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseController : ControllerBase
    {
        private readonly IClaseService _claseService;

        public ClaseController(IClaseService claseService)
        {
            _claseService = claseService;
        }

        [HttpPost]
        public ActionResult Post(Clase clase)
        {
            _claseService.Add(clase);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<DtoClase>> GetAll()
        {
            return Ok(_claseService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<DtoClase> GetById(int id)
        {
            var clase = _claseService.GetById(id);
            if (clase == null) return NotFound();
            return Ok(clase);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Clase clase)
        {
            if (id != clase.Id) return BadRequest();

            _claseService.Update(clase);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _claseService.Delete(id);
            return NoContent();
        }
    }
}
