using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
namespace Infrastructure
{
    public class ClaseRepository: IClasesRepository
    {
        public List<Clase> Clases { get; set; }
        public ClaseRepository() {
            Clases = new List<Clase>
            {
                new Clase {
                    Id = 0,
                    Horario = new TimeSpan(14, 30, 0),
                    DiasSemana = [
                        "Lunes", 
                        "Martes"
                        ],

                    Nombre = "Judo",
                    ProfesorClase = new Profesor()
                                    {
                                        Email = "Profe@gmail.com",
                                        Id = 1,
                                        Nombre = "Profe",
                                        Apellido = " Profe",
                                        Activo = true,
                                           Password = "123456",
                    },
                    UsuariosInscriptos = [
                                            new Usuario
                                            {
                                                Id = 1,
                                                Activo = true,
                                                Nombre = "Alumno1",
                                                Apellido = "apellido1",
                                                Email = "Alumno1@gmail.com",
                                                Password = "password"
                                            }
                        ]
                }
            };
        }
        public List<Clase> GetAll()
        {
            return Clases;
        }
    }
}
