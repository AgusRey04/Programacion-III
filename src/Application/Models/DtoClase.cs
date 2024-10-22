using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entities.Clase;

namespace Application.Models
{
    public class DtoClase
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Horario { get; set; }


        public List<DiaDeLaSemana> DiasDeLaSemana { get; set; } = new List<DiaDeLaSemana>();

        public List<string>? Alumnos { get; set; }

        public static DtoClase Create(Clase clase)
        {
            return new DtoClase
            {
                Id = clase.Id,
                Nombre = clase.Nombre,
                Horario = clase.Horario.ToString(),
                //DiasDeLaSemana = 
            };
        }

        public static List<DtoClase> CreateList(IEnumerable<Clase> clases)
        {
            return clases.Select(Create).ToList();
        }
    }
}
