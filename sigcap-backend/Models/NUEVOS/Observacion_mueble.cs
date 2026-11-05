using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Observacion_mueble
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public string Observacion { get; set; }
        public Mueble Mueble{ get; set; }
        public Observacion_mueble()
        {
        }

    }
}
