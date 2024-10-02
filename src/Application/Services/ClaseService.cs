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
    public class ClaseService: IClaseService
    {
        private readonly IClasesRepository _clasesRepository;
        public ClaseService(IClasesRepository clasesRepository)
        {
            _clasesRepository = clasesRepository;
        }

        public List<Clase> GetAll()
        {
            return _clasesRepository.GetAll();
        }
    }
}
