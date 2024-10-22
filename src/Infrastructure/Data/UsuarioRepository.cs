using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddUser(Usuario usuario)
        {
            _context.Set<Usuario>().Add(usuario);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> GetUsers()
        {
            return _context.Set<Usuario>().ToList();
        }

        public Usuario GetUserById(int id)
        {
            return _context.Set<Usuario>().Find(id);
        }

        public void UpdateUser(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var usuario = _context.Set<Usuario>().Find(id);
            if (usuario != null)
            {
                _context.Set<Usuario>().Remove(usuario);
                _context.SaveChanges();
            }
        }
        public bool EmailExists(string email)
            
        {
            return _context.Set<Usuario>().Any(u => u.Email == email);
        }
    }
}
