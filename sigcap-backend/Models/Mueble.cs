using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Mueble
    {
        public int Id { get; set; }
        public Vehiculo? vehiculo { get; set; }
        public Codigo_qr? codigo_Qr { get; set; }
        public List<Observacion_mueble>? Observaciones{ get; set;}
        public Mueble()
        {
        }

    }
}
