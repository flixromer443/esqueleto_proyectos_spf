using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Historico_estado_alerta_recuento_fisico
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Alerta_recuento_fisico Alerta{  get; set; }
        public Historico_estado_alerta_recuento_fisico()
        {
        }

    }
}
