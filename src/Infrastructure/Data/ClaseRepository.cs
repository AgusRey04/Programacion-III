using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class ClaseRepository : IClaseRepository
    {
        private readonly ApplicationContext _context;

        public ClaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddClase(Clase clase)
        {
            _context.Set<Clase>().Add(clase);
            _context.SaveChanges();
        }

        public IEnumerable<Clase> GetClases()
        {
            return _context.Set<Clase>().ToList();
        }

        public Clase GetClaseById(int id)
        {
            return _context.Set<Clase>().Find(id);
        }

        public void UpdateClase(Clase clase)
        {
            _context.Entry(clase).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteClase(int id)
        {
            var clase = _context.Set<Clase>().Find(id);
            if (clase != null)
            {
                _context.Set<Clase>().Remove(clase);
                _context.SaveChanges();
            }
        }
    }
}
