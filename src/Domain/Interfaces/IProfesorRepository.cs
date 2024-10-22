using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public interface IProfesorRepository
    {
        public void AddProfesor(Profesor profesor);
        public IEnumerable<Profesor> GetProfesors();
        public Profesor GetProfesorById(int id);
        public void UpdateProfesor(Profesor profesor);
        public void DeleteProfesor(int id);
        public bool EmailExists(string email);
    }
}
