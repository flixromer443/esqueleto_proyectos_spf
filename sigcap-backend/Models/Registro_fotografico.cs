using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Registro_fotografico
    {
        public int Id { get; set; }
        public string Uri_imagen{ get; set; }
        public Inmueble? Mueble{ get; set; }
        public Bien? bien {get; set; }
        public Ficha_tecnica? ficha_Tecnica { get; set; } 
        public Registro_fotografico()
        {
        }

    }
}
