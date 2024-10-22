using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AdministradorService : IAdministradorService
    {
        private readonly IAdministradorRepository _administradorRepository;

        public AdministradorService(IAdministradorRepository administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        public void AddAdministrador(ResponseCrearPersona adminRequest)
        {
            var admin = new Administrador
            {
                Nombre = adminRequest.Nombre,
                Apellido = adminRequest.Apellido,
                Email = adminRequest.Email,
                Password = adminRequest.Password,
                Activo = true
            };
            _administradorRepository.AddAdministrador(admin);
        }

        public IEnumerable<DtoAdministrador> GetAllAdministradores()
        {
            _administradorRepository.GetAdministradores();
            return DtoAdministrador.CreateList(_administradorRepository.GetAdministradores());
        }

        public DtoAdministrador GetAdministradorById(int id)
        {
            var admin = _administradorRepository.GetAdministradorById(id);
            if (admin == null)
            {
                return null;
            }
            return DtoAdministrador.Create(admin);
        }

        public void UpdateAdministrador( Administrador adminData)
        {
            _administradorRepository.UpdateAdministrador(adminData);


        }

        public void DeleteAdministrador(int id)
        {
            _administradorRepository.DeleteAdministrador(id);
        }
    }
}
