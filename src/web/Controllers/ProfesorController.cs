using Application.Models.Requests;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using Application.Models.Requests;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;


namespace web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProfesorController : ControllerBase
    {


        private readonly IProfesorService _profesorService;

        public ProfesorController(IProfesorService profesorService)
        {
            _profesorService = profesorService;
        }


        [HttpGet]

        public ActionResult<IEnumerable<DtoProfesor>> GetAll()
        {


            return Ok(_profesorService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<DtoProfesor> GetById(int id)
        {
            var profesor = _profesorService.GetById(id);
            if (profesor == null) return NotFound();
            return Ok(profesor);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Profesor profesor)
        {
            if (id != profesor.Id) return BadRequest();

            _profesorService.Update(profesor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _profesorService.Delete(id);
            return NoContent();
        }





    }
}
