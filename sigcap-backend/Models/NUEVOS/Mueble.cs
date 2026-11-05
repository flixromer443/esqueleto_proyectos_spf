using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Mueble
    {
        public int Id { get; set; }
        List<Observacion_mueble> Observacion_mueble{ get; set;}
        public Mueble()
        {
        }

    }
}
