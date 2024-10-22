using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAdministradorRepository
    {
        void AddAdministrador(Administrador administrador);
        IEnumerable<Administrador> GetAdministradores();
        Administrador GetAdministradorById(int id);
        void UpdateAdministrador(Administrador administrador);
        void DeleteAdministrador(int id);
    }
}
