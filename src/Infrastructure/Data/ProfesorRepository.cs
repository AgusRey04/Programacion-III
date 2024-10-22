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
   public class ProfesorRepository : IProfesorRepository
    {
        private readonly ApplicationContext _context;

        public ProfesorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddProfesor(Profesor profesor)
        {
            _context.Set<Profesor>().Add(profesor);
            _context.SaveChanges();
        }

        public IEnumerable<Profesor> GetProfesors()
        {
            return _context.Set<Profesor>().ToList();
        }

        public Profesor? GetProfesorById(int id)
        {
            return _context.Set<Profesor>().Find(id);
        }

        public void UpdateProfesor(Profesor profesor)
        {
            _context.Entry(profesor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProfesor(int id)
        {
            var profesor = _context.Set<Profesor>().Find(id);
            if (profesor != null)
            {
                _context.Set<Profesor>().Remove(profesor);
                _context.SaveChanges();
            }
        }
        public bool EmailExists(string email)

        {
            return _context.Set<Profesor>().Any(u => u.Email == email);
        }
    }
}
