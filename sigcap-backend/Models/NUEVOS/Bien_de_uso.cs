using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Bien_de_uso
    {
        public int Id { get; set; }
        public Bien Bien{ get; set; }
        public Tipo_baja Tipo_Baja { get; set; }
        public Mueble? Mueble { get; set; }
        List<Observacion_bien> Observacion_bien { get; set;}
        public Bien_de_uso()
        {
        }

    }
}
