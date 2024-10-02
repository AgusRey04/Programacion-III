using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AdministradorService: IAdministradorService
    {
        private readonly IAdministradorRepository _administradorRepository;

        public AdministradorService(IAdministradorRepository administratorRepository)
        {
            _administradorRepository = administratorRepository;
        }


        public List<Administrador>  GetAll()
        {
            return _administradorRepository.GetAdministradores();
        }

    }
}
