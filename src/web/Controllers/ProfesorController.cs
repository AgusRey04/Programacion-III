using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Application.Interfaces;
namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly  IProfesorService _profesorService; 
        public ProfesorController(IProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        [HttpGet]
        public IActionResult GetProfesor()
        {
            return Ok(_profesorService.GetProfesores()); // Agregué el paréntesis de cierre
        }


    }
}

