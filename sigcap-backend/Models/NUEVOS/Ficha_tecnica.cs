using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Ficha_tecnica
    {
        public int Id { get; set; }
        public Estado_operativo Estado_operativo{ get; set; }
        public Estado_afectacion Estado_afectacion { get; set; }
        public Combustible Combustible { get; set; }
        public Vehiculo vehiculo { get; set; }
        public Ficha_tecnica()
        {
        }

    }
}
