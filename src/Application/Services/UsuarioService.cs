using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public void Add(Usuario usuario)
        {
            _usuarioRepository.AddUser(usuario);
        }

        public  List<Usuario> GetAll() { 
            return _usuarioRepository.GetUsers();

        }

        public void Update( Usuario usuario)
        {
            _usuarioRepository.UpdateUser(usuario);
        }

        public Usuario GetById(int Id)
        {
            return _usuarioRepository.GetByIdUser(Id);
        }
    }
}
