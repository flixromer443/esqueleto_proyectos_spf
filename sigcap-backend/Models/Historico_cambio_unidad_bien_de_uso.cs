using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Historico_cambio_unidad_bien_de_uso
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Unidad Unidad_actual { get; set; }
        public Unidad Unidad_anterior { get; set; }
        public Usuario usuario { get; set; }
        public Bien_de_uso bien {  get; set; }
        public Historico_cambio_unidad_bien_de_uso()
        {
        }

    }
}
