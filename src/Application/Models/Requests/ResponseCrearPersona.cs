using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class ResponseCrearPersona
    {

        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "invalid Email Address")]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}

