using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Historico_estado_afectacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Bien_de_uso bien {  get; set; }
        public Estado_afectacion Estado{ get; set; }
        public Historico_estado_afectacion()
        {
        }

    }
}
