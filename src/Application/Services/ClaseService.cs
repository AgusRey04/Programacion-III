using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class ClaseService : IClaseService
    {
        private readonly IClaseRepository _claseRepository;

        public ClaseService(IClaseRepository claseRepository)
        {
            _claseRepository = claseRepository;
        }

        public void Add(Clase clase)
        {
            _claseRepository.AddClase(clase);
        }

        public IEnumerable<DtoClase> GetAll()
        {
            return DtoClase.CreateList(_claseRepository.GetClases());
        }

        public DtoClase GetById(int id)
        {
            var clase = _claseRepository.GetClaseById(id);
            if (clase == null)
            {
                return null;
            }
            return DtoClase.Create(clase);
        }

        public void Update(Clase clase)
        {
            _claseRepository.UpdateClase(clase);
        }

        public void Delete(int id)
        {
            _claseRepository.DeleteClase(id);
        }

        public bool CupoDisponible(int claseId)
        {
            var clase = _claseRepository.GetClaseById(claseId);
            return clase != null && clase.UsuariosInscriptos.Count < 15; 
        }
    }
}
