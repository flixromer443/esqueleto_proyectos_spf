using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Bien_de_uso
    {
        public int Id { get; set; }
        public Bien Bien{ get; set; }
        public Tipo_baja Tipo_Baja { get; set; }
        public Mueble? Mueble { get; set; }
        public Inmueble? Inmueble { get; set; }
        public Bien_de_uso()
        {
        }

    }
}
