using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Historico_estado_tarjeta_combustible
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Tarjeta_combustible tarjeta_combustible{  get; set; }
        public Estado_tarjeta_combustible Estado{ get; set; }
        public Historico_estado_tarjeta_combustible()
        {
        }

    }
}
