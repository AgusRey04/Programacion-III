using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AdministradorRepository:IAdministradorRepository
    {
        public List<Administrador> Administradores { get; set; }

        public AdministradorRepository()
        {
            Administradores = new List<Administrador> {
                new Administrador()
                {
                    Id = 0,
                    Activo = true,
                    Apellido = "Perez",
                    Nombre = "Carlos",
                    Email = "Carlos@gmail.com",
                    Password = "Admin123",
                    Clases = [],
                    Profesores = [],
                    Usuarios = []

                }
            };
        }
          public List<Administrador> GetAdministradores()
            {
                return Administradores;
            }

            

        }
    }

