using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IClaseRepository
    {
        void AddClase(Clase clase);
        IEnumerable<Clase> GetClases();
        Clase GetClaseById(int id);
        void UpdateClase(Clase clase);
        void DeleteClase(int id);
    }
}
