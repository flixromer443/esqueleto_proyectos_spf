using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Historico_situacion_dominial
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario usuario { get; set; }
        public Inmueble inmueble{  get; set; }
        public Situacion_dominial Situacion{ get; set; }
        public Historico_situacion_dominial()
        {
        }

    }
}
