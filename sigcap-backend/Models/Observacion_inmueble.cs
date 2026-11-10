using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Observacion_inmueble
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public string Observacion { get; set; }
        public Inmueble Inmueble{ get; set; }
        public Observacion_inmueble()
        {
        }

    }
}
