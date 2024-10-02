using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : Controller
    {
        private readonly IAdministradorService _administradorService;
        private readonly IProfesorService _profesorService;
        private readonly IUsuarioService _suarioService;
        public AdministradorController(IAdministradorService administradorService, IProfesorService profesorService, IUsuarioService suarioService)
        {
            _administradorService = administradorService;
            _profesorService = profesorService;
            _suarioService = suarioService;
        }


        [HttpGet("Get-Administradores")]
        public IActionResult Get()
        {
            return Ok(_administradorService.GetAll());
        }

        [HttpGet("Get-Profesores")]
        public IActionResult GetProfesor()
        {
            return Ok(_profesorService.GetProfesores()); 
        }

        [HttpGet("Get-Usuiarios")]
        public ActionResult<List<Usuario>> GetUsuario() // con IActionResult no se utiliza el <List<Usuario>>
        {
            return _suarioService.GetAll().ToList();
        }

    }
}
