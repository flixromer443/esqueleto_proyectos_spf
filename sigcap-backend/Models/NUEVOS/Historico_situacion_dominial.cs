using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models.NUEVOS
{
    public class Historico_situacion_dominial
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Bien_de_uso bien {  get; set; }
        public Situacion_dominial Situacion{ get; set; }
        public Historico_situacion_dominial()
        {
        }

    }
}
