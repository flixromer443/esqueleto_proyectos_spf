using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public Unidad unidad { get; set; }
        public Codigo_presupuestario Codigo_presupuestario { get; set; }
        public List<Bien>? Bienes {  get; set; }
        public Presupuesto()
        {
        }

    }
}
