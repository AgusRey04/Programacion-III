using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ProfesorRepository: IProfesorRepository
    {
        public List<Profesor> Profesores { get; set; }

        public ProfesorRepository() 
        {
            Profesores = new List<Profesor>
            {
                new Profesor()
                {
                    Email = "Profe@gmail.com",
                    Id = 1,
                    Nombre = "Profe",
                    Apellido = " Profe",
                    Activo = true,
                    Password = "123456",
                    

                },
                 new Profesor()
                 {
                     Email = "Profe2@gmail.com",
                     Id = 2,
                     Nombre = "Profe2",
                     Apellido = " Profe2",
                     Activo = true,
                     Password = "654321",


                 }
            };

 
        }

        public List<Profesor> GetAll()
        {
            return Profesores;
        }
    }
}

