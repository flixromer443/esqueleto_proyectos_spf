using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public DateTime F_ingreso{ get; set; }
        public DateTime F_alta { get; set; }
        public DateTime F_observacion { get; set; }
        public int Kilometraje{ get; set; }
        public Ficha_tecnica Ficha_tecnica { get; set; }
        public Taller_mecanico Taller_mecanico { get; set; }

        public string Descripcion{ get; set; }
        public Mantenimiento()
        {
        }

    }
}
