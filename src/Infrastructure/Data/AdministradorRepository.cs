using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AdministradorRepository : IAdministradorRepository
    {
        private readonly ApplicationContext _context;

        public AdministradorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddAdministrador(Administrador administrador)
        {
            _context.Set<Administrador>().Add(administrador);
            _context.SaveChanges();
        }

        public IEnumerable<Administrador> GetAdministradores()
        {
            return _context.Set<Administrador>().ToList();
        }

        public Administrador GetAdministradorById(int id)
        {
            return _context.Set<Administrador>().Find(id);
        }

        public void UpdateAdministrador(Administrador administrador)
        {
            _context.Entry(administrador).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAdministrador(int id)
        {
            var administrador = _context.Set<Administrador>().Find(id);
            if (administrador != null)
            {
                _context.Set<Administrador>().Remove(administrador);
                _context.SaveChanges();
            }
        }
    }
}
