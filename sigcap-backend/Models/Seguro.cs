using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Seguro
    {
        public int Id { get; set; }
        public string Descripcion{ get; set; }
        public double Valor_cuota{ get; set; }

        public Seguro()
        {
        }

    }
}
