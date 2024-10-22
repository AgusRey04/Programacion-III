using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProfesorService
    {
        public void Add(ResponseCrearPersona profesor);
        public IEnumerable<DtoProfesor> GetAll();
        public DtoProfesor? GetById(int id);
        public void Update(Profesor profesor);
        public void Delete(int id);

        public bool EmailExists(string email);



    }
}
