using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<Usuario> Usuarios { get; set; }
        public UsuarioRepository()
        {
            Usuarios = new List<Usuario>
        {
            new Usuario
            {
                Id = 1,
                Activo = true,
                Nombre = "Alumno1",
                Apellido = "apellido1",
                Email = "Alumno1@gmail.com",
                Password = "password"
            }
        };
        }

        public List<Usuario> GetUsers()
        {
           return Usuarios;
        }
        public Usuario GetByIdUser(int Id) {
            Usuario usuario_encontrado = Usuarios.FirstOrDefault(u => u.Id == Id);
            return usuario_encontrado;
        }

        public void AddUser(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void UpdateUser(Usuario usuario)
        {
            var existingUsuario = Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            if (existingUsuario != null)
            {
                existingUsuario.Nombre = usuario.Nombre;
                existingUsuario.Apellido = usuario.Apellido;
                existingUsuario.Email = usuario.Email;
                existingUsuario.Password = usuario.Password;
                existingUsuario.Activo = usuario.Activo;
            }
        }

        //public void DeleteUser(int Id)
        //{
        //    var existingUsuario = Usuarios.FirstOrDefault(u => u.Id == Id);
        //    if (existingUsuario != null)
        //    {
        //        existingUsuario.Activo = false;
        //    }
        //}
    }
}
