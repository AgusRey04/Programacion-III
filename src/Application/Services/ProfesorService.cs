using Application.Models.Requests;
using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Services
{
    public class ProfesorService: IProfesorService
    {
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorService(IProfesorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        public void Add(ResponseCrearPersona profesor)
        {

            var newProfesor = new Profesor()
            {
                Nombre = profesor.Nombre,
                Apellido = profesor.Apellido,
                Activo = true,
                Email = profesor.Email,
                Password = profesor.Password,
            };
            _profesorRepository.AddProfesor(newProfesor);
        }

        public IEnumerable<DtoProfesor> GetAll()
        {
            var dto = _profesorRepository.GetProfesors();
            return DtoProfesor.CreateList(dto);
        }

        public DtoProfesor?  GetById(int id)
        {
            var dto = _profesorRepository.GetProfesorById(id);
            return DtoProfesor.Create(dto);
        }

        public void Update(Profesor profesor)
        {
            _profesorRepository.UpdateProfesor(profesor);
        }

        public void Delete(int id)
        {
            _profesorRepository.DeleteProfesor(id);

        }
        public bool EmailExists(string email)
        {
            return _profesorRepository.EmailExists(email);
        }
    }
}
