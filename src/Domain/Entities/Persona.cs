using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Persona
    {
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "invalid Email Address")]
        public string? Email { get; set; }

        public bool Activo { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
