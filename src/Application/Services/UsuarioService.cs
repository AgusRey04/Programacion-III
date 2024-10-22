using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Add(ResponseCrearPersona usuario)
        {
            var nuevoUsuario = new Usuario
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
                Password = usuario.Password,
                Activo = true,
                UltimoPago = DateTime.Now
            };
            _usuarioRepository.AddUser(nuevoUsuario);
        }

        public IEnumerable<DtoUsuario> GetAll()
        {
            VerificarBajas(); // Llamar a la verificación antes de obtener todos los usuarios
            return DtoUsuario.CreateList(_usuarioRepository.GetUsers());
        }

        public DtoUsuario GetById(int id)
        {
            VerificarBajas(); // Llamar a la verificación antes de obtener un usuario por ID
            var usuario = _usuarioRepository.GetUserById(id);

            if (usuario == null)
            {
                return null;
            }
            return  DtoUsuario.Create(usuario);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.UpdateUser(usuario);
        }

        public void Delete(int id)
        {
            _usuarioRepository.DeleteUser(id);
        }

        public bool EmailExists(string email)
        {
            return _usuarioRepository.EmailExists(email);
        }

        private void VerificarBajas()
        {
            var usuarios = _usuarioRepository.GetUsers();
            foreach (var usuario in usuarios)
            {
                
                if ((DateTime.Now - usuario.UltimoPago).TotalDays > 30)
                {
                    
                    usuario.Activo = false;
                    usuario.Clases.Clear();
                    _usuarioRepository.UpdateUser(usuario);
                }
            }
        }
    }
}
