using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Alerta_recuento_fisico
    {
        public int Id { get; set; }
        public Unidad Unidad{ get; set; }
        public DateTime F_creacion { get; set; }
        public DateTime F_recuento { get; set; }
        public Estado_alerta_recuento_fisico Estado_alerta_recuento_fisico { get; set; }
        public Alerta_recuento_fisico()
        {
        }

    }
}
