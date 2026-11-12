using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Partida_presupuestaria
    {
        public int Id { get; set; }
        public Unidad unidad { get; set; }
        public Codigo_presupuestario Codigo_presupuestario { get; set; }
        public Clase Clase { get; set; }
        public Subclase Subclase { get; set; }
        public List<Bien>? Bienes {  get; set; }
        public Partida_presupuestaria()
        {
        }

    }
}
