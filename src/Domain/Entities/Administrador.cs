using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Administrador:Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
        public ICollection<Clase> Clases { get; set; } = new List<Clase>();

    }
}
