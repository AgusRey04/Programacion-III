using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : ControllerBase
    {
        private readonly IProfesorService _profesorService;

        public AdministradorController(IProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

       
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
