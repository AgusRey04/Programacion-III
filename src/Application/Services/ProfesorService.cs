using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
namespace Application.Services
{
    public class ProfesorService : IProfesorService
    {

        private readonly IProfesorRepository _profesorRepository;

        public ProfesorService(IProfesorRepository profesorRepository)
        {
            _profesorRepository= profesorRepository;
        }

        public List<Profesor> GetProfesores()
        {
            return _profesorRepository.GetAll(); // Cambié esta línea
        }
    }
}
