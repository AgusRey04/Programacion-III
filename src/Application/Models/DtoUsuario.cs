using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class DtoUsuario
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

        public static DtoUsuario Create(Usuario usuario)
        {
            return new DtoUsuario
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Email = usuario.Email,
            };
        }

        public static List<DtoUsuario> CreateList(IEnumerable<Usuario> subjects)
        {
            List<DtoUsuario> listDto = [];
            foreach (var s in subjects)
            {
                listDto.Add(Create(s));
            }

            return listDto;
        }



    }


   
}
