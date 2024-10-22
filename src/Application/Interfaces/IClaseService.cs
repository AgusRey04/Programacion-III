using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClaseService
    {
        void Add(Clase clase);
        IEnumerable<DtoClase> GetAll();
        DtoClase GetById(int id);
        void Update(Clase clase);
        void Delete(int id);
        bool CupoDisponible(int claseId);
    }
}
