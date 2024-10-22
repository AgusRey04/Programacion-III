using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Clase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<Usuario> UsuariosInscriptos { get; set; } = new List<Usuario>();
        public string Nombre { get; set; }
        public Profesor ProfesorClase { get; set; }
        public TimeSpan Horario { get; set; }
        public List<DiaDeLaSemana> DiasSemana { get; set; }
       
        public enum DiaDeLaSemana
        {
            Lunes,
            Martes,
            Miércoles,
            Jueves,
            Viernes,
            Sábado,
            Domingo
        }
    }
}
