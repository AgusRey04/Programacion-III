using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Clases
    {
        public ICollection<Usuario> UsuariosInscriptos { get; set; } = new List<Usuario>();
        public string Nombre { get; set; }
        public Profesor ProfesorClase { get; set; }
        public DateTime Horario {  get; set; }
    
    }
}
