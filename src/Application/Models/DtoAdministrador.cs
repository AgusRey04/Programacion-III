using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class DtoAdministrador
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "invalid Email Address")]
        public string? Email { get; set; }

        public static DtoAdministrador Create(Administrador administrador)
        {
            return new DtoAdministrador
            {
                Id = administrador.Id,
                Nombre = administrador.Nombre,
                Apellido = administrador.Apellido,
                Email = administrador.Email,
            };
        }

        public static List<DtoAdministrador> CreateList(IEnumerable<Administrador> subjects)
        {
            List<DtoAdministrador> listDto = [];
            foreach (var s in subjects)
            {
                listDto.Add(Create(s));
            }

            return listDto;
        }
    }
}
