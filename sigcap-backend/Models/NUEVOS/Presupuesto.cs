using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public Codigo_presupuestario Codigo_presupuestario { get; set; }
        public Presupuesto()
        {
        }

    }
}
