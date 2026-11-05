using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Tarjeta_combustible
    {
        public int Id { get; set; }
        public DateTime F_emision { get; set; }
        public DateTime F_vencimiento { get; set;  }
        public string Titular{ get; set; }
        public int CVV{ get; set; }
        public string Bco_emisor{ get; set; }
        public string Numero{ get; set; }
        public Estado_tarjeta_combustible Estado_tarjeta_combustible { get; set; }
        public Ficha_tecnica Ficha_tecnica{ get; set; }
        public List<Agente_asociado>? Agentes_asociados { get; set; }

        public Tarjeta_combustible()
        {
        }

    }
}
