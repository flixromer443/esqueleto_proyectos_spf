using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Dispositivo_telepase
    {
        public int Id { get; set; }
        public DateTime F_emision { get; set; }
        public DateTime F_baja { get; set; }
        public string Numero { get; set; }
        public Ficha_tecnica Ficha_tecnica { get; set; }
        public Estado_dispositivo_telepase Estado_dispositivo_telepase { get; set; }
        public string Descripcion{ get; set; }
        public Dispositivo_telepase()
        {
        }

    }
}
