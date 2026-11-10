using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Vida_util
    {
        public int Id { get; set; }
        public double Anios_vida_util{ get; set; }
        public double Porc_amortizacion{ get; set; }
        public Codigo_presupuestario codigo_presupuestario{ get; set; }
        public Vida_util()
        {
        }

    }
}
