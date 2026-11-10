using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Historico_estado_dispositivo_telepase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Dispositivo_telepase dispositivo_telepase{ get; set; }
        public Estado_dispositivo_telepase Estado{ get; set; }
        public Historico_estado_dispositivo_telepase()
        {
        }

    }
}
