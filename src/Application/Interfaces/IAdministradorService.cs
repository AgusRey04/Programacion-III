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
   public interface IAdministradorService
    {
        void AddAdministrador(ResponseCrearPersona adminRequest);
        IEnumerable<DtoAdministrador> GetAllAdministradores();
        DtoAdministrador GetAdministradorById(int id);
        public void UpdateAdministrador(Administrador adminData);
        void DeleteAdministrador(int id);
    }
}
