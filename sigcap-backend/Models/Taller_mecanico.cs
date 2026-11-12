using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Taller_mecanico
    {
        public int Id { get; set; }
        public string Cod_postal{ get; set; }
        public string Calle{ get; set; }
        public int numero { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Entrecalle_1 { get; set; }
        public string Entrecalle_2 { get; set; }
        public string Denominacion { get; set; }
        public string Cuit{ get; set; }

        public Taller_mecanico()
        {
        }

    }
}
