using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Codigo_qr
    {
        public int Id { get; set; }
        public string Codigo{ get; set; }
        public DateTime F_creacion { get; set; }
        public Mueble mueble { get; set; }
        public Inmueble inmueble { get; set; }

        public Codigo_qr()
        {
        }

    }
}
