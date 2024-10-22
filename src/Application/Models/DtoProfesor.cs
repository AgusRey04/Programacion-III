using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
   public class DtoProfesor
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

        public static DtoProfesor? Create(Profesor profesor)
        {
            
            return new DtoProfesor
            {
                Id = profesor.Id,
                Nombre = profesor.Nombre,
                Apellido = profesor.Apellido,
                Email = profesor.Email,
            };
        }

        public static List<DtoProfesor> CreateList(IEnumerable<Profesor> subjects)
        {
            List<DtoProfesor> listDto = [];
            foreach (var s in subjects)
            {
                listDto.Add(Create(s));
            }

            return listDto;
        }



    }
}

