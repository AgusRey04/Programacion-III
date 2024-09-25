using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Administrador : Persona
    {
        private ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
        private ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();      
        private ICollection<Clases> Clases { get; set; } = new List<Clases>();
    }
}
