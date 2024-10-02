using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;


        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("Get-Usuiarios")]
        public ActionResult<List<Usuario>> Get() // IActionResult no se utiliza el <List<Usuario>>
        {
            return Ok(_usuarioService.GetAll().ToList());
        }

        [HttpPost]
        public IActionResult Add(Usuario usuario)
        {

            _usuarioService.Add(usuario);
            return NoContent();

        }
        [HttpPut]
        public IActionResult Update(Usuario usuario)
        {
            _usuarioService.Update(usuario);
            return NoContent();
        }

        [HttpGet("GetById-Usuiarios")]
        public IActionResult GetById(int id)
        {
            return Ok(_usuarioService.GetById(id));
        }




    }
}
