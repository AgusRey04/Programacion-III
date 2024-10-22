using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public ActionResult<DtoUsuario> Post(ResponseCrearPersona usuario)
        {
            if (_usuarioService.EmailExists(usuario.Email))
            {
                return BadRequest("El usuario ya esta registrado");
            }
            _usuarioService.Add(usuario);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<DtoUsuario>> GetAll()
        {

       
            return Ok(_usuarioService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<DtoUsuario> GetById(int id)
        {
            var usuario = _usuarioService.GetById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Usuario usuario)
        {
            if (id != usuario.Id) return BadRequest();

            _usuarioService.Update(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _usuarioService.Delete(id);
            return NoContent();
        }
    }
}
