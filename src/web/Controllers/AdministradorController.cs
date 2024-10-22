using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : ControllerBase
    {
        private readonly IAdministradorService _administradorService;
        private readonly IProfesorService _profesorService;

        public AdministradorController(IAdministradorService administradorService, IProfesorService profesorService)
        {
            _administradorService = administradorService;
            _profesorService = profesorService;
        }


        // Alta de Administrador
        [HttpPost]
        public ActionResult<DtoAdministrador> AddAdministrador(ResponseCrearPersona adminRequest)
        {
            _administradorService.AddAdministrador(adminRequest);
            return Ok();
        }

        // Consulta de todos los Administradores
        [HttpGet]
        public ActionResult<IEnumerable<DtoAdministrador>> GetAllAdministradores()
        {
            return Ok(_administradorService.GetAllAdministradores());
        }

        // Consulta por Id
        [HttpGet("{id}")]
        public ActionResult<DtoAdministrador> GetAdministradorById(int id)
        {
            var admin = _administradorService.GetAdministradorById(id);
            if (admin == null) return NotFound();
            return Ok(admin);
        }

        // Modificación de Administrador
        [HttpPut("{id}")]
        public ActionResult UpdateAdministrador(int id, Administrador adminData)
        {
            if (id != adminData.Id) return BadRequest();
            _administradorService.UpdateAdministrador(adminData);

            return NoContent();
        }

        // Baja de Administrador
        [HttpDelete("{id}")]
        public ActionResult DeleteAdministrador(int id)
        {
            _administradorService.DeleteAdministrador(id);
            return NoContent();
        }

        // Alta de Profesor por Administrador
        [HttpPost("profesor")]
        public ActionResult<DtoProfesor> AddProfesor(ResponseCrearPersona profesor)
        {
            if (_profesorService.EmailExists(profesor.Email))
            {
                return BadRequest("El usuario ya está registrado");
            }
            _profesorService.Add(profesor);
            return Ok();
        }
    }
}
