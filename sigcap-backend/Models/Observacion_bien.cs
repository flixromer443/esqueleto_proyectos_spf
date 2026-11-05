using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigcapbackend.Models
{
    public class Observacion_bien
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public string Observacion { get; set; }
        public Bien Bien{ get; set; }
        public Observacion_bien()
        {
        }

    }
}
